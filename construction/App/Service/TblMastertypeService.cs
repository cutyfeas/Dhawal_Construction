using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;

namespace App.Service
{
    public interface ITblMastertypeService
    {
        Task<List<TblMastertype>> GetAll_TblMastertype();
        Task<TblMastertype> Get_TblMastertype(int? postId);
        Task<int> Add_TblMastertype(TblMastertype post);
        Task Update_TblMastertype(TblMastertype post);
        Task<int> Delete_TblMastertype(int? postId);

    }
    public class TblMastertypeService : ITblMastertypeService
    {
        AppContext db;
        public TblMastertypeService(AppContext _db)
        {
            db = _db;
        }

        public async Task<List<TblMastertype>> GetAll_TblMastertype()
        {
            if (db != null)
            {
                return await db.TblMastertypes.ToListAsync();
            }

            return null;
        }
        public async Task<TblMastertype> Get_TblMastertype(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblMastertypes
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblMastertype(TblMastertype TblMastertype)
        {
            if (db != null)
            {
                await db.TblMastertypes.AddAsync(TblMastertype);
                await db.SaveChangesAsync();

                return TblMastertype.Id;
            }

            return 0;
        }
        public async Task Update_TblMastertype(TblMastertype TblMastertype)
        {
            if (db != null)
            {
                //Delete that post
                db.TblMastertypes.Update(TblMastertype);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblMastertype(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var val = await db.TblMastertypes.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that post
                    db.TblMastertypes.Remove(val);

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
