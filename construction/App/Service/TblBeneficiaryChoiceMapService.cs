using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;

namespace App.Service
{
    public interface ITblBeneficiaryChoiceMapService
    {
        Task<List<TblBeneficiaryChoiceMap>> GetAll_TblBeneficiaryChoiceMap();
        Task<TblBeneficiaryChoiceMap> Get_TblBeneficiaryChoiceMap(int? postId);
        Task<int> Add_TblBeneficiaryChoiceMap(TblBeneficiaryChoiceMap post);
        Task Update_TblBeneficiaryChoiceMap(TblBeneficiaryChoiceMap post);
        Task<int> Delete_TblBeneficiaryChoiceMap(int? postId);

    }
    public class TblBeneficiaryChoiceMapService : ITblBeneficiaryChoiceMapService
    {
        AppContext db;
        public TblBeneficiaryChoiceMapService(AppContext _db)
        {
            db = _db;
        }

        public async Task<List<TblBeneficiaryChoiceMap>> GetAll_TblBeneficiaryChoiceMap()
        {
            if (db != null)
            {
                return await db.TblBeneficiaryChoiceMaps.ToListAsync();
            }

            return null;
        }
        public async Task<TblBeneficiaryChoiceMap> Get_TblBeneficiaryChoiceMap(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblBeneficiaryChoiceMaps
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblBeneficiaryChoiceMap(TblBeneficiaryChoiceMap TblBeneficiaryChoiceMap)
        {
            if (db != null)
            {
                await db.TblBeneficiaryChoiceMaps.AddAsync(TblBeneficiaryChoiceMap);
                await db.SaveChangesAsync();

                return TblBeneficiaryChoiceMap.Id;
            }

            return 0;
        }
        public async Task Update_TblBeneficiaryChoiceMap(TblBeneficiaryChoiceMap TblBeneficiaryChoiceMap)
        {
            if (db != null)
            {
                //Delete that post
                db.TblBeneficiaryChoiceMaps.Update(TblBeneficiaryChoiceMap);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblBeneficiaryChoiceMap(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var val = await db.TblBeneficiaryChoiceMaps.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that post
                    db.TblBeneficiaryChoiceMaps.Remove(val);

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
