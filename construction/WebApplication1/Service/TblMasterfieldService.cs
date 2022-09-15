using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
    public interface ITblMasterfieldService
    {
        Task<List<TblMasterfield>> GetAll_TblMasterfield();
        Task<TblMasterfield> Get_TblMasterfield(int? postId);
        Task<int> Add_TblMasterfield(TblMasterfield post);
        Task Update_TblMasterfield(TblMasterfield post);
        Task<int> Delete_TblMasterfield(int? postId);

    }
    public class TblMasterfieldService : ITblMasterfieldService
    {
        db_a67321_constructionappContext db;
        public TblMasterfieldService(db_a67321_constructionappContext _db)
        {
            db = _db;
        }

        public async Task<List<TblMasterfield>> GetAll_TblMasterfield()
        {
            if (db != null)
            {
                return await db.TblMasterfields.ToListAsync();
            }

            return null;
        }
        public async Task<TblMasterfield> Get_TblMasterfield(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblMasterfields
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblMasterfield(TblMasterfield TblMasterfield)
        {
            if (db != null)
            {
                await db.TblMasterfields.AddAsync(TblMasterfield);
                await db.SaveChangesAsync();

                return TblMasterfield.Id;
            }

            return 0;
        }
        public async Task Update_TblMasterfield(TblMasterfield TblMasterfield)
        {
            if (db != null)
            {
                //Delete that post
                db.TblMasterfields.Update(TblMasterfield);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblMasterfield(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var val = await db.TblMasterfields.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that post
                    db.TblMasterfields.Remove(val);

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
