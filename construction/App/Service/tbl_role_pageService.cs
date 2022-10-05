using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;
using App.Models;

namespace App.Service
{
    public interface Itbl_role_pageService
    {
        Task<List<tbl_role_page>> GetAll_tbl_role_page();
        Task<tbl_role_page> Get_tbl_role_page(int id);
        Task<int> Add_tbl_role_page(tbl_role_page data);
        Task Update_tbl_role_page(tbl_role_page data);
        Task<int> Delete_tbl_role_page(int? id);
        Task Add_tbl_role_page(usermodel m);
        Task Update_tbl_role_page(usermodel m);
    }
    public class tbl_role_pageService : Itbl_role_pageService
    {
        ConAppContext db;
        public tbl_role_pageService(ConAppContext _db)
        {
            db = _db;
        }

        public async Task<List<tbl_role_page>> GetAll_tbl_role_page()
        {
            if (db != null)
            {
                return await db.tbl_role_page.ToListAsync();
            }

            return null;
        }
        public async Task<tbl_role_page> Get_tbl_role_page(int Id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_role_page
                              where p.id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_tbl_role_page(tbl_role_page tbl_role_page)
        {
            if (db != null)
            {
                await db.tbl_role_page.AddAsync(tbl_role_page);
                await db.SaveChangesAsync();

                return tbl_role_page.id;
            }

            return 0;
        }
        public async Task Update_tbl_role_page(tbl_role_page tbl_role_page)
        {
            if (db != null)
            {
                //Delete that data
                db.tbl_role_page.Update(tbl_role_page);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_tbl_role_page(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.tbl_role_page.FirstOrDefaultAsync(x => x.id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.tbl_role_page.Remove(val);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public Task Add_tbl_role_page(usermodel m)
        {
            var e = new tbl_role_page
            {
                roleid = m.roleid,
                pageid=m.pageid,
                createddate = System.DateTime.Now,
            };
            return this.Add_tbl_role_page(e);
        }

        public async Task Update_tbl_role_page(usermodel m)
        {
            var e = await this.Get_tbl_role_page(m.rolepageid);
            e.roleid = m.roleid;
            e.pageid = m.pageid;
            e.updateddate = System.DateTime.Now;
            await this.Update_tbl_role_page(e);
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
