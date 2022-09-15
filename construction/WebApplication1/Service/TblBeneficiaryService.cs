using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
    public interface ITblBeneficiarieservice
    {
        Task<List<TblBeneficiary>> GetAll_TblBeneficiary();
        Task<TblBeneficiary> Get_TblBeneficiary(int? postId);
        Task<int> Add_TblBeneficiary(TblBeneficiary post);
        Task Update_TblBeneficiary(TblBeneficiary post);
        Task<int> Delete_TblBeneficiary(int? postId);

    }
    public class TblBeneficiarieservice : ITblBeneficiarieservice
    {
        db_a67321_constructionappContext db;
        public TblBeneficiarieservice(db_a67321_constructionappContext _db)
        {
            db = _db;
        }

        public async Task<List<TblBeneficiary>> GetAll_TblBeneficiary()
        {
            if (db != null)
            {
                return await db.TblBeneficiaries.ToListAsync();
            }

            return null;
        }
        public async Task<TblBeneficiary> Get_TblBeneficiary(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblBeneficiaries
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblBeneficiary(TblBeneficiary TblBeneficiary)
        {
            if (db != null)
            {
                await db.TblBeneficiaries.AddAsync(TblBeneficiary);
                await db.SaveChangesAsync();

                return TblBeneficiary.Id;
            }

            return 0;
        }
        public async Task Update_TblBeneficiary(TblBeneficiary TblBeneficiary)
        {
            if (db != null)
            {
                //Delete that post
                db.TblBeneficiaries.Update(TblBeneficiary);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblBeneficiary(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var val = await db.TblBeneficiaries.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that post
                    db.TblBeneficiaries.Remove(val);

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
