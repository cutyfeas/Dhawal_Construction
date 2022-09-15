using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
    public interface ITblSupplierService
    {
        Task<List<TblSupplier>> GetAll_TblSupplier();
        Task<TblSupplier> Get_TblSupplier(int? id);
        Task<int> Add_TblSupplier(TblSupplier data);
        Task Update_TblSupplier(TblSupplier data);
        Task<int> Delete_TblSupplier(int? id);

    }
    public class TblSupplierService : ITblSupplierService
    {
        db_a67321_constructionappContext db;
        public TblSupplierService(db_a67321_constructionappContext _db)
        {
            db = _db;
        }

        public async Task<List<TblSupplier>> GetAll_TblSupplier()
        {
            if (db != null)
            {
                return await db.TblSuppliers.ToListAsync();
            }

            return null;
        }
        public async Task<TblSupplier> Get_TblSupplier(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblSuppliers
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblSupplier(TblSupplier TblSupplier)
        {
            if (db != null)
            {
                await db.TblSuppliers.AddAsync(TblSupplier);
                await db.SaveChangesAsync();

                return TblSupplier.Id;
            }

            return 0;
        }
        public async Task Update_TblSupplier(TblSupplier TblSupplier)
        {
            if (db != null)
            {
                //Delete that data
                db.TblSuppliers.Update(TblSupplier);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblSupplier(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.TblSuppliers.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.TblSuppliers.Remove(val);

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
