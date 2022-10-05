using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;
using App.Models;

namespace App.Service
{
    public interface Itbl_pageservice
    {
        Task<List<tbl_pages>> GetAll_tbl_pages();
        Task<tbl_pages> Get_tbl_pages(int? id);
        Task<int> Add_tbl_pages(tbl_pages data);
        Task Update_tbl_pages(tbl_pages data);
        Task<int> Delete_tbl_pages(int? id);
        Task<int> Add_tbl_pages(usermodel m);
        Task Update_tbl_pages(usermodel m);
    }
    public class tbl_pageservice : Itbl_pageservice
    {
        ConAppContext db;
        public tbl_pageservice(ConAppContext _db)
        {
            db = _db;
        }

        public async Task<List<tbl_pages>> GetAll_tbl_pages()
        {
            if (db != null)
            {
                return await db.tbl_pages.ToListAsync();
            }

            return null;
        }
        public async Task<tbl_pages> Get_tbl_pages(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_pages
                              where p.id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_tbl_pages(tbl_pages tbl_pages)
        {
            if (db != null)
            {
                await db.tbl_pages.AddAsync(tbl_pages);
                await db.SaveChangesAsync();

                return tbl_pages.id;
            }

            return 0;
        }
        public async Task Update_tbl_pages(tbl_pages tbl_pages)
        {
            if (db != null)
            {
                //Delete that data
                db.tbl_pages.Update(tbl_pages);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_tbl_pages(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.tbl_pages.FirstOrDefaultAsync(x => x.id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.tbl_pages.Remove(val);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public Task<int> Add_tbl_pages(usermodel data)
        {
            var e = new tbl_pages
            {
                pagename = data.pagename,
                createddate = System.DateTime.Now,
            };
            return this.Add_tbl_pages(e);
        }

        public async Task Update_tbl_pages(usermodel m)
        {
            var e = await this.Get_tbl_pages(m.pageid);
            e.pagename = m.pagename;
            e.updateddate = System.DateTime.Now;
            await this.Update_tbl_pages(e);
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
