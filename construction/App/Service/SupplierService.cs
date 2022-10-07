using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;
using App.Models;
using System;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace App.Service
{
    public interface ISupplierService
    {
        Task<List<tbl_mastertype>> GetAll_mastertypelist();
        Task<int> Add_mastertype(suppliermodel m);
        Task<int> Update_mastertype(suppliermodel m);
        Task<int> Delete_mastertype(int id);
        Task<tbl_mastertype> GetAll_mastertype(int id);


        Task<List<tbl_masterfields>> GetAll_masterfieldlist();
        Task<int> Add_masterfield(suppliermodel m);
        Task<int> Update_masterfield(suppliermodel m);
        Task<int> Delete_masterfield(int id);
        Task<tbl_masterfields> GetAll_masterfield(int id);


        Task<List<tbl_mastertypefields>> GetAll_mastertypefieldlist();
        Task<int> Add_mastertypefield(suppliermodel m);
        Task<int> Update_mastertypefield(suppliermodel m);
        Task<int> Delete_mastertypefield(int id);
        Task<tbl_mastertypefields> GetAll_mastertypefield(int id);


        Task<List<tbl_suppliers>> GetAll_supplierlist();
        Task<int> Add_supplier(suppliermodel m);
        Task<int> Update_supplier(suppliermodel m);
        Task<int> Delete_supplier(int id);
        Task<tbl_suppliers> GetAll_supplier(int id);


        Task<List<tbl_mastertype_supplier_map>> GetAll_mastertypesupplierlist();
        Task<int> Add_mastertypesupplier(suppliermodel m);
        Task<int> Update_mastertypesupplier(suppliermodel m);
        Task<int> Delete_mastertypesupplier(int id);
        Task<tbl_mastertype_supplier_map> GetAll_mastertypesupplier(int id);


    }
    public class SupplierService : ISupplierService
    {
        ConAppContext db;
        //Itbl_userService tbl_userService;

        public SupplierService(ConAppContext _db)
        {
            db = _db;
        }

        #region master type

        public async Task<List<tbl_mastertype>> GetAll_mastertypelist()
        {
            if (db != null)
            {
                return await db.tbl_mastertype.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_mastertype(suppliermodel m)
        {
            var e = m.mastertype;
            e.createddate = DateTime.Now;
            if (db != null)
            {
                await db.tbl_mastertype.AddAsync(e);
                await db.SaveChangesAsync();

                return e.id;
            }
            return 0;
        }

        public async Task<int> Update_mastertype(suppliermodel m)
        {
            int result = 0;
            var e = await db.tbl_mastertype.FirstOrDefaultAsync(x => x.id == m.mastertype.id);

            e.description = m.mastertype.description;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_mastertype.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_mastertype(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_mastertype.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_mastertype.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_mastertype> GetAll_mastertype(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_mastertype
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion



        #region master field
        public async Task<List<tbl_masterfields>> GetAll_masterfieldlist()
        {
            if (db != null)
            {
                return await db.tbl_masterfields.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_masterfield(suppliermodel m)
        {
            var e = m.masterfield;
            e.createddate = DateTime.Now;
            if (db != null)
            {
                await db.tbl_masterfields.AddAsync(e);
                await db.SaveChangesAsync();

                return e.id;
            }
            return 0;
        }

        public async Task<int> Update_masterfield(suppliermodel m)
        {
            int result = 0;
            var e = await db.tbl_masterfields.FirstOrDefaultAsync(x => x.id == m.masterfield.id);

            e.name = m.masterfield.name;
            e.datatype = m.masterfield.datatype;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_masterfields.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_masterfield(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_masterfields.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_masterfields.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_masterfields> GetAll_masterfield(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_masterfields
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion


        #region master type field
        public async Task<List<tbl_mastertypefields>> GetAll_mastertypefieldlist()
        {
            if (db != null)
            {
                return await db.tbl_mastertypefields.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_mastertypefield(suppliermodel m)
        {
            var e = m.mastertypefield;
            e.createddate = DateTime.Now;
            if (db != null)
            {
                await db.tbl_mastertypefields.AddAsync(e);
                await db.SaveChangesAsync();

                return e.id;
            }
            return 0;
        }

        public async Task<int> Update_mastertypefield(suppliermodel m)
        {
            int result = 0;
            var e = await db.tbl_mastertypefields.FirstOrDefaultAsync(x => x.id == m.mastertypefield.id);

            e.mastertypeid = m.mastertypefield.mastertypeid;
            e.masterfieldid = m.mastertypefield.masterfieldid;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_mastertypefields.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_mastertypefield(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_mastertypefields.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_mastertypefields.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_mastertypefields> GetAll_mastertypefield(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_mastertypefields
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion


        #region supplier
        public async Task<List<tbl_suppliers>> GetAll_supplierlist()
        {
            if (db != null)
            {
                return await db.tbl_suppliers.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_supplier(suppliermodel m)
        {
            var e = m.supplier;
            e.createddate = DateTime.Now;
            if (db != null)
            {
                await db.tbl_suppliers.AddAsync(e);
                await db.SaveChangesAsync();

                return e.id;
            }
            return 0;
        }

        public async Task<int> Update_supplier(suppliermodel m)
        {
            int result = 0;
            var e = await db.tbl_suppliers.FirstOrDefaultAsync(x => x.id == m.supplier.id);

            e.name = m.supplier.name;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_suppliers.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_supplier(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_suppliers.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_suppliers.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_suppliers> GetAll_supplier(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_suppliers
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion




        #region master type supplier
        public async Task<List<tbl_mastertype_supplier_map>> GetAll_mastertypesupplierlist()
        {
            if (db != null)
            {
                return await db.tbl_mastertype_supplier_map.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_mastertypesupplier(suppliermodel m)
        {
            var e = m.mastertypesupplier;
            e.createddate = DateTime.Now;
            if (db != null)
            {
                await db.tbl_mastertype_supplier_map.AddAsync(e);
                await db.SaveChangesAsync();

                return e.id;
            }
            return 0;
        }

        public async Task<int> Update_mastertypesupplier(suppliermodel m)
        {
            int result = 0;
            var e = await db.tbl_mastertype_supplier_map.FirstOrDefaultAsync(x => x.id == m.mastertypesupplier.id);

            e.mastertypeid = m.mastertypesupplier.mastertypeid;
            e.supplierid = m.mastertypesupplier.supplierid;
            e.quotedvalue = m.mastertypesupplier.quotedvalue;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_mastertype_supplier_map.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_mastertypesupplier(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_mastertype_supplier_map.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_mastertype_supplier_map.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_mastertype_supplier_map> GetAll_mastertypesupplier(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_mastertype_supplier_map
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion







    }
}
