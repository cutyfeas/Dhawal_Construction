using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Service
{
    public interface ITblApartmentService
    {
        Task<List<TblApartment>> GetAll_TblApartment();
        Task<TblApartment> Get_TblApartment(int? postId);
        Task<int> Add_TblApartment(TblApartment post);
        Task Update_TblApartment(TblApartment post);
        Task<int> Delete_TblApartment(int? postId);

    }
    public class TblApartmentService : ITblApartmentService
    {
        db_a67321_constructionappContext db;
        public TblApartmentService(db_a67321_constructionappContext _db)
        {
            db = _db;
        }

        public async Task<List<TblApartment>> GetAll_TblApartment()
        {
            if (db != null)
            {
                return await db.TblApartments.ToListAsync();
            }

            return null;
        }
        public async Task<TblApartment> Get_TblApartment(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.TblApartments
                              where p.Id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblApartment(TblApartment TblApartment)
        {
            if (db != null)
            {
                await db.TblApartments.AddAsync(TblApartment);
                await db.SaveChangesAsync();

                return TblApartment.Id;
            }

            return 0;
        }
        public async Task Update_TblApartment(TblApartment TblApartment)
        {
            if (db != null)
            {
                //Delete that post
                db.TblApartments.Update(TblApartment);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblApartment(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var val = await db.TblApartments.FirstOrDefaultAsync(x => x.Id == Id);

                if (val != null)
                {
                    //Delete that post
                    db.TblApartments.Remove(val);

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
