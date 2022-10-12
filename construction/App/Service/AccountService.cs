using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;
using App.Models;
using System;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace App.Service
{
    public interface IAccountService
    {
        Task<loginrespmodel> login(loginmodel m);
        Task<string> Register(loginmodel m);
    }
    public class AccountService : IAccountService
    {
        ConAppContext db;
        //Itbl_userService tbl_userService;

        public AccountService(ConAppContext _db)
        {
            db = _db;
            // tbl_userService = _tbl_userService;
        }

        public async Task<loginrespmodel> login(loginmodel model)
        {
            var result = new loginrespmodel();

            var user = (from x in db.tbl_user
                        where
                        x.username.ToLower().Trim() == model.username.ToLower().Trim() &&
                        x.pswd.ToLower().Trim() == model.pswd.ToLower().Trim() &&
                        x.IsActive == true
                        select x).FirstOrDefault();

            if (user == null)
            {
                result.error = "Invalid username or password";
                return result;
            }
            else
            {
                result.AccessToken = Guid.NewGuid().ToString();
                UserToken ut = new UserToken
                {
                    UserId = user.id,
                    IsActive = true,
                    IssuedOn = DateTime.Now,
                    ExpiresOn = DateTime.Now.AddMinutes(20),
                    Token = result.AccessToken
                };
                db.UserToken.Add(ut);
                db.SaveChanges();

                result.userid = user.id;
                result.UserName = user.username;
                result.IsAdmin = user.roleid == 1;
                result.roleid = user.roleid;

                return result;
            }
        }

        public async Task<string> Register(loginmodel model)
        {

            var user = await (from p in db.tbl_user
                              where p.username.ToLower().Trim() == model.username.ToLower().Trim()
                              select p).FirstOrDefaultAsync();

            if (user == null)
            {
                var rand = new Random();
                var password = rand.Next().ToString().Replace(".", "").Substring(0, 5);


                var entity = new tbl_user
                {
                    username = model.username,
                    pswd = model.pswd,
                    roleid = 2,
                    createddate = DateTime.Now,
                    IsActive = true,
                };
                await db.tbl_user.AddAsync(entity);
                await db.SaveChangesAsync();
                var userid = entity.id;


                //send email with password

                return "An email with password has been sent to your email.";

                //string Emailbody = string.Empty;
                //using (StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/Utility/Mailer/Welcome.html")))
                //{
                //    Emailbody = reader.ReadToEnd();
                //}
                //Emailbody = Emailbody.Replace("{user}", model.username);
                //Emailbody = Emailbody.Replace("{username}", model.username);
                //Emailbody = Emailbody.Replace("{password}", password);

                //var msg = EmailService.email(new string[] { model.Email }, Emailbody, "BRKS: WELCOME !!");

                //if (msg.Success)
                //    return "An email with password has been sent to your email.";
                //else
                //    return "Your account is created but we could not send you mail due to some techinical error. Please contact administrator.";
            }
            else
            {
                return "User with same email already exist";
            }

        }

    }
}
