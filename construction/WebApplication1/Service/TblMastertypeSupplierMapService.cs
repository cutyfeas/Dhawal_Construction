using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
    public interface ITblMastertypeSupplierMapService
    {
        Task<List<TblMastertypeSupplierMap>> GetAll_TblMastertypeSupplierMap();
        Task<TblMastertypeSupplierMap> Get_TblMastertypeSupplierMap(int? postId);
        Task<int> Add_TblMastertypeSupplierMap(TblMastertypeSupplierMap post);
        Task Update_TblMastertypeSupplierMap(TblMastertypeSupplierMap post);
        Task<int> Delete_TblMastertypeSupplierMap(int? postId);

    }
    public class TblMastertypeSupplierMapService : ITblMastertypeSupplierMapService
    {
        db_a67321_constructionappContext db;
        public TblMastertypeSupplierMapService(db_a67321_constructionappContext _db)
        {
            db = _db;
        }

        public async Task<List<TblMastertypeSupplierMap>> GetAll_TblMastertypeSupplierMap()
        {
            if (db != null)
            {
                return await db.TblMastertypeSupplierMaps.ToListAsync();
            }

            return null;
        }
        public async Task<TblMastertypeSupplierMap> Get_TblMastertypeSupplierMap(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblMastertypeSupplierMaps
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblMastertypeSupplierMap(TblMastertypeSupplierMap TblMastertypeSupplierMap)
        {
            if (db != null)
            {
                await db.TblMastertypeSupplierMaps.AddAsync(TblMastertypeSupplierMap);
                await db.SaveChangesAsync();

                return TblMastertypeSupplierMap.Id;
            }

            return 0;
        }
        public async Task Update_TblMastertypeSupplierMap(TblMastertypeSupplierMap TblMastertypeSupplierMap)
        {
            if (db != null)
            {
                //Delete that post
                db.TblMastertypeSupplierMaps.Update(TblMastertypeSupplierMap);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblMastertypeSupplierMap(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var val = await db.TblMastertypeSupplierMaps.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that post
                    db.TblMastertypeSupplierMaps.Remove(val);

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
