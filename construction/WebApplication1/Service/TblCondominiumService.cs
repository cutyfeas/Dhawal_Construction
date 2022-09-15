using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
    public interface ITblCondominiumService
    {
        Task<List<TblCondominium>> GetAll_TblCondominium();
        Task<TblCondominium> Get_TblCondominium(int? postId);
        Task<int> Add_TblCondominium(TblCondominium post);
        Task Update_TblCondominium(TblCondominium post);
        Task<int> Delete_TblCondominium(int? postId);

    }
    public class TblCondominiumService : ITblCondominiumService
    {
        db_a67321_constructionappContext db;
        public TblCondominiumService(db_a67321_constructionappContext _db)
        {
            db = _db;
        }

        public async Task<List<TblCondominium>> GetAll_TblCondominium()
        {
            if (db != null)
            {
                return await db.TblCondominia.ToListAsync();
            }

            return null;
        }
        public async Task<TblCondominium> Get_TblCondominium(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblCondominia
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblCondominium(TblCondominium TblCondominium)
        {
            if (db != null)
            {
                await db.TblCondominia.AddAsync(TblCondominium);
                await db.SaveChangesAsync();

                return TblCondominium.Id;
            }

            return 0;
        }
        public async Task Update_TblCondominium(TblCondominium TblCondominium)
        {
            if (db != null)
            {
                //Delete that post
                db.TblCondominia.Update(TblCondominium);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblCondominium(int? Id)
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
