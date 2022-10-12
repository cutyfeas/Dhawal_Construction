using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;
using App.Models;

namespace App.Service
{
    public interface Itbl_userService
    {
        Task<List<tbl_user>> GetAll_tbl_user();
        Task<tbl_user> Get_tbl_user(int? id);
        Task<tbl_user> Get_tbl_user(string username);
        Task<int> Add_tbl_user(tbl_user data);
        Task Update_tbl_user(tbl_user data);
        Task<int> Delete_tbl_user(int? id);
        Task Add_tbl_user(usermodel m);
        Task Update_tbl_user(usermodel m);
    }
    public class tbl_userService : Itbl_userService
    {
        ConAppContext db;
        public tbl_userService(ConAppContext _db)
        {
            db = _db;
        }

        public async Task<List<tbl_user>> GetAll_tbl_user()
        {
            if (db != null)
            {
                return await db.tbl_user.ToListAsync();
            }

            return null;
        }
        public async Task<tbl_user> Get_tbl_user(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_user
                              where p.id == Id
                              select p).FirstOrDefaultAsync();
            }

            return new tbl_user();
        }
        public async Task<tbl_user> Get_tbl_user(string username)
        {
            if (db != null)
            {
                return await (from p in db.tbl_user
                              where p.username.ToLower().Trim() == username.ToLower().Trim()
                              select p).FirstOrDefaultAsync();
            }
            return new tbl_user();
        }
        public async Task<int> Add_tbl_user(tbl_user tbl_user)
        {
            if (db != null)
            {
                await db.tbl_user.AddAsync(tbl_user);
                await db.SaveChangesAsync();

                return tbl_user.id;
            }

            return 0;
        }
        public async Task Update_tbl_user(tbl_user tbl_user)
        {
            if (db != null)
            {
                //Delete that data
                db.tbl_user.Update(tbl_user);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_tbl_user(int? Id)
        {
            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_user.FirstOrDefaultAsync(x => x.id == Id);

                if (e != null)
                {
                    e.IsActive = false;
                    await this.Update_tbl_user(e);
                    return 1;

                    //Delete that data
                    //db.tbl_user.Remove(val);

                    //Commit the transaction
                    //result = await db.SaveChangesAsync();
                }
                return 0;
            }

            return 0;
        }

        public Task Add_tbl_user(usermodel m)
        {
            var e = new tbl_user
            {
                username = m.username,
                pswd = m.pswd,
                roleid = m.roleid,
                IsActive = true,
                createddate = System.DateTime.Now,
            };
            return this.Add_tbl_user(e);
        }

        public async Task Update_tbl_user(usermodel m)
        {
            var e = await this.Get_tbl_user(m.userid);
            e.username = m.username;
            e.pswd = m.pswd;
            e.roleid = m.roleid;
            e.updateddate = System.DateTime.Now;
            await this.Update_tbl_user(e);
        }



        //public async Task<List<dataViewModel>> Getdatas()
        //{
        //    if (db != null)
        //    {
        //        return await (from p in db.data
        //                      from c in db.Category
        //                      where p.CategoryId == c.Id
        //                      select new dataViewModel
        //                      {
        //                          id = p.id,
        //                          Title = p.Title,
        //                          Description = p.Description,
        //                          CategoryId = p.CategoryId,
        //                          CategoryName = c.Name,
        //                          CreatedDate = p.CreatedDate
        //                      }).ToListAsync();
        //    }

        //    return null;
        //}
    }
}
