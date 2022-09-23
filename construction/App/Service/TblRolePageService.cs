using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;

namespace App.Service
{
    public interface ITblRolePageService
    {
        Task<List<TblRolePage>> GetAll_TblRolePage();
        Task<TblRolePage> Get_TblRolePage(int? id);
        Task<int> Add_TblRolePage(TblRolePage data);
        Task Update_TblRolePage(TblRolePage data);
        Task<int> Delete_TblRolePage(int? id);

    }
    public class TblRolePageService : ITblRolePageService
    {
        AppContext db;
        public TblRolePageService(AppContext _db)
        {
            db = _db;
        }

        public async Task<List<TblRolePage>> GetAll_TblRolePage()
        {
            if (db != null)
            {
                return await db.TblRolePages.ToListAsync();
            }

            return null;
        }
        public async Task<TblRolePage> Get_TblRolePage(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblRolePages
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblRolePage(TblRolePage TblRolePage)
        {
            if (db != null)
            {
                await db.TblRolePages.AddAsync(TblRolePage);
                await db.SaveChangesAsync();

                return TblRolePage.Id;
            }

            return 0;
        }
        public async Task Update_TblRolePage(TblRolePage TblRolePage)
        {
            if (db != null)
            {
                //Delete that data
                db.TblRolePages.Update(TblRolePage);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblRolePage(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.TblRolePages.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.TblRolePages.Remove(val);

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
