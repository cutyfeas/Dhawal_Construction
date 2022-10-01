using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;
using App.Models;

namespace App.Service
{
    public interface Itbl_roleService
    {
        Task<List<tbl_role>> GetAll_TblRole();
        Task<tbl_role> Get_TblRole(int? id);
        Task<int> Add_TblRole(tbl_role data);
        Task Update_TblRole(tbl_role data);
        Task<int> Delete_TblRole(int? id);

        Task<int> Add_TblRole(usermodel data);
        Task Update_TblRole(usermodel m);
    }
    public class tbl_roleService : Itbl_roleService
    {
        ConAppContext db;
        public tbl_roleService(ConAppContext _db)
        {
            db = _db;
        }

        public async Task<List<tbl_role>> GetAll_TblRole()
        {
            if (db != null)
            {
                return await db.tbl_role.OrderByDescending(x => x.id).ToListAsync();
            }

            return null;
        }
        public async Task<tbl_role> Get_TblRole(int? Id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_role
                              where p.id == Id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<int> Add_TblRole(tbl_role TblRole)
        {
            if (db != null)
            {
                await db.tbl_role.AddAsync(TblRole);
                await db.SaveChangesAsync();

                return TblRole.id;
            }

            return 0;
        }
        public async Task Update_TblRole(tbl_role TblRole)
        {
            if (db != null)
            {
                //Delete that data
                db.tbl_role.Update(TblRole);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task<int> Delete_TblRole(int? Id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var val = await db.tbl_role.FirstOrDefaultAsync(x => x.id == Id);

                if (val != null)
                {
                    //Delete that data
                    db.tbl_role.Remove(val);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public Task<int> Add_TblRole(usermodel data)
        {
            var e = new tbl_role
            {
                rolename = data.rolename,
                createddate = System.DateTime.Now,
            };
            return this.Add_TblRole(e);
        }

        public async Task Update_TblRole(usermodel m)
        {
            var e = await this.Get_TblRole(m.roleid);
            e.rolename = m.rolename;
            e.updateddate = System.DateTime.Now;
            await this.Update_TblRole(e);
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
