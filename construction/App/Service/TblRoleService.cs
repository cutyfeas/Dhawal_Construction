using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;

namespace App.Service
{
    public interface ITblRoleService
    {
        Task<List<TblRole>> GetAll_TblRole();
        Task<TblRole> Get_TblRole(int? id);
        Task<int> Add_TblRole(TblRole data);
        Task Update_TblRole(TblRole data);
        Task<int> Delete_TblRole(int? id);

    }
    public class TblRoleService : ITblRoleService
    {
        AppContext db;
        public TblRoleService(AppContext _db)
        {
            db = _db;
        }

        public async Task<List<TblRole>> GetAll_TblRole()
        {
            if (db != null)
            {
                return await db.TblRoles.ToListAsync();
            }

            return null;
        }
        public async Task<TblRole> Get_TblRole(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblRoles
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblRole(TblRole TblRole)
        {
            if (db != null)
            {
                await db.TblRoles.AddAsync(TblRole);
                await db.SaveChangesAsync();

                return TblRole.Id;
            }

            return 0;
        }
        public async Task Update_TblRole(TblRole TblRole)
        {
            if (db != null)
            {
                //Delete that data
                db.TblRoles.Update(TblRole);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblRole(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.TblRoles.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.TblRoles.Remove(val);

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
