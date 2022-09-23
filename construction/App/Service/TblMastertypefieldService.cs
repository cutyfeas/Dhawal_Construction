using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;

namespace App.Service
{
    public interface ITblMastertypefieldService
    {
        Task<List<TblMastertypefield>> GetAll_TblMastertypefield();
        Task<TblMastertypefield> Get_TblMastertypefield(int? Id);
        Task<int> Add_TblMastertypefield(TblMastertypefield data);
        Task Update_TblMastertypefield(TblMastertypefield data);
        Task<int> Delete_TblMastertypefield(int? Id);

    }
    public class TblMastertypefieldService : ITblMastertypefieldService
    {
        AppContext db;
        public TblMastertypefieldService(AppContext _db)
        {
            db = _db;
        }

        public async Task<List<TblMastertypefield>> GetAll_TblMastertypefield()
        {
            if (db != null)
            {
                return await db.TblMastertypefields.ToListAsync();
            }

            return null;
        }
        public async Task<TblMastertypefield> Get_TblMastertypefield(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblMastertypefields
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblMastertypefield(TblMastertypefield TblMastertypefield)
        {
            if (db != null)
            {
                await db.TblMastertypefields.AddAsync(TblMastertypefield);
                await db.SaveChangesAsync();

                return TblMastertypefield.Id;
            }

            return 0;
        }
        public async Task Update_TblMastertypefield(TblMastertypefield TblMastertypefield)
        {
            if (db != null)
            {
                //Delete that data
                db.TblMastertypefields.Update(TblMastertypefield);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblMastertypefield(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.TblMastertypefields.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.TblMastertypefields.Remove(val);

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
        //                          Id = p.Id,
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
