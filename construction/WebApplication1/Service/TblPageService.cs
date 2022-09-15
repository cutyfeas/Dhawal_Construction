using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
    public interface ITblPageService
    {
        Task<List<TblPage>> GetAll_TblPage();
        Task<TblPage> Get_TblPage(int? id);
        Task<int> Add_TblPage(TblPage data);
        Task Update_TblPage(TblPage data);
        Task<int> Delete_TblPage(int? id);

    }
    public class TblPageService : ITblPageService
    {
        db_a67321_constructionappContext db;
        public TblPageService(db_a67321_constructionappContext _db)
        {
            db = _db;
        }

        public async Task<List<TblPage>> GetAll_TblPage()
        {
            if (db != null)
            {
                return await db.TblPages.ToListAsync();
            }

            return null;
        }
        public async Task<TblPage> Get_TblPage(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblPages
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblPage(TblPage TblPage)
        {
            if (db != null)
            {
                await db.TblPages.AddAsync(TblPage);
                await db.SaveChangesAsync();

                return TblPage.Id;
            }

            return 0;
        }
        public async Task Update_TblPage(TblPage TblPage)
        {
            if (db != null)
            {
                //Delete that data
                db.TblPages.Update(TblPage);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblPage(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.TblPages.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.TblPages.Remove(val);

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
