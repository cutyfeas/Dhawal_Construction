using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;

namespace App.Service
{
    public interface Itbl_condominiumService
    {
        Task<List<tbl_condominium>> GetAll_tbl_condominium();
        Task<tbl_condominium> Get_tbl_condominium(int? postId);
        Task<int> Add_tbl_condominium(tbl_condominium post);
        Task Update_tbl_condominium(tbl_condominium post);
        Task<int> Delete_tbl_condominium(int? postId);

    }
    public class tbl_condominiumService : Itbl_condominiumService
    {
        AppContext db;
        public tbl_condominiumService(AppContext _db)
        {
            db = _db;
        }

        public async Task<List<tbl_condominium>> GetAll_tbl_condominium()
        {
            if (db != null)
            {
                return await db.TblCondominia.ToListAsync();
            }

            return null;
        }
        public async Task<tbl_condominium> Get_tbl_condominium(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblCondominia
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_tbl_condominium(tbl_condominium tbl_condominium)
        {
            if (db != null)
            {
                await db.TblCondominia.AddAsync(tbl_condominium);
                await db.SaveChangesAsync();

                return tbl_condominium.Id;
            }

            return 0;
        }
        public async Task Update_tbl_condominium(tbl_condominium tbl_condominium)
        {
            if (db != null)
            {
                //Delete that post
                db.TblCondominia.Update(tbl_condominium);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_tbl_condominium(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var val = await db.TblCondominia.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that post
                    db.TblCondominia.Remove(val);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }



        //public async Task<List<PostViewModel>> GetPosts()
        //{
        //    if (db != null)
        //    {
        //        return await (from p in db.Post
        //                      from c in db.Category
        //                      where p.CategoryId == c.Id
        //                      select new PostViewModel
        //                      {
        //                          PostId = p.PostId,
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
