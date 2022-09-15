using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
    public interface ITblUserService
    {
        Task<List<TblUser>> GetAll_TblUser();
        Task<TblUser> Get_TblUser(int? id);
        Task<int> Add_TblUser(TblUser data);
        Task Update_TblUser(TblUser data);
        Task<int> Delete_TblUser(int? id);

    }
    public class TblUserService : ITblUserService
    {
        db_a67321_constructionappContext db;
        public TblUserService(db_a67321_constructionappContext _db)
        {
            db = _db;
        }

        public async Task<List<TblUser>> GetAll_TblUser()
        {
            if (db != null)
            {
                return await db.TblUsers.ToListAsync();
            }

            return null;
        }
        public async Task<TblUser> Get_TblUser(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblUsers
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return new TblUser();
        }
        public async Task<int> Add_TblUser(TblUser TblUser)
        {
            if (db != null)
            {
                await db.TblUsers.AddAsync(TblUser);
                await db.SaveChangesAsync();

                return TblUser.Id;
            }

            return 0;
        }
        public async Task Update_TblUser(TblUser TblUser)
        {
            if (db != null)
            {
                //Delete that data
                db.TblUsers.Update(TblUser);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblUser(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.TblUsers.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.TblUsers.Remove(val);

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
