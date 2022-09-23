using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;

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
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.tbl_user.FirstOrDefaultAsync(x => x.id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.tbl_user.Remove(val);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
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
