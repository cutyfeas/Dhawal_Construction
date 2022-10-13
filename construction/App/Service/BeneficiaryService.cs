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
    public interface IBeneficiaryService
    {

        Task<List<tbl_beneficiary>> GetAll_beneficiarylist();
        Task<int> Add_beneficiary(beneficiarymodel m);
        Task<int> Update_beneficiary(beneficiarymodel m);
        Task<int> Delete_beneficiary(int id);
        Task<tbl_beneficiary> GetAll_beneficiary(int id);


        Task<List<tbl_beneficiary_choice_map>> GetAll_beneficiary_maplist();
        Task<int> Add_beneficiary_map(beneficiarymodel m);
        Task<int> Update_beneficiary_map(beneficiarymodel m);
        Task<int> Delete_beneficiary_map(int id);
        Task<tbl_beneficiary_choice_map> GetAll_beneficiary_map(int id);
    }
    public class BeneficiaryService : IBeneficiaryService
    {
        ConAppContext db;
        //Itbl_userService tbl_userService;

        public BeneficiaryService(ConAppContext _db)
        {
            db = _db;
        }

        #region beneficiary

        public async Task<List<tbl_beneficiary>> GetAll_beneficiarylist()
        {
            if (db != null)
            {
                return await db.tbl_beneficiary.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_beneficiary(beneficiarymodel m)
        {
            var e = m.beneficiary;
            e.createddate = DateTime.Now;
            if (db != null)
            {
                await db.tbl_beneficiary.AddAsync(e);
                await db.SaveChangesAsync();

                return e.id;
            }
            return 0;
        }

        public async Task<int> Update_beneficiary(beneficiarymodel m)
        {
            int result = 0;
            var e = await db.tbl_beneficiary.FirstOrDefaultAsync(x => x.id == m.beneficiary.id);

            e.apartmentid = m.beneficiary.apartmentid;
            e.clientid = m.beneficiary.clientid;
            e.condominiumid = m.beneficiary.condominiumid;
            e.firstname = m.beneficiary.firstname;
            e.lastname = m.beneficiary.lastname;
            e.taxcode = m.beneficiary.taxcode;
            e.email = m.beneficiary.email;
            e.phone = m.beneficiary.phone;
            e.Sheet = m.beneficiary.Sheet;
            e.Parcel = m.beneficiary.Parcel;
            e.Subdivision = m.beneficiary.Subdivision;
            e.building = m.beneficiary.building;
            e.staircase = m.beneficiary.staircase;
            e.interior = m.beneficiary.interior;
            e.cadastralcategory = m.beneficiary.cadastralcategory;
            e.sqm = m.beneficiary.sqm;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_beneficiary.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_beneficiary(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_beneficiary.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_beneficiary.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_beneficiary> GetAll_beneficiary(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_beneficiary
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion



        #region beneficiary_map
        public async Task<List<tbl_beneficiary_choice_map>> GetAll_beneficiary_maplist()
        {
            if (db != null)
            {
                return await db.tbl_beneficiary_choice_map.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_beneficiary_map(beneficiarymodel m)
        {
            var list = new List<tbl_beneficiary_choice_map>();
            foreach (var x in m.mastertypeids)
            {
                var e = m.beneficiary_map;
                e.mastertypeid = x;
                e.createddate = DateTime.Now;
                list.Add(e);
            }
            if (db != null)
            {
                await db.tbl_beneficiary_choice_map.AddRangeAsync(list);
                await db.SaveChangesAsync();

                return 1;
            }
            return 0;
        }

        public async Task<int> Update_beneficiary_map(beneficiarymodel m)
        {
            int result = 0;
            var e = await db.tbl_beneficiary_choice_map.FirstOrDefaultAsync(x => x.id == m.beneficiary_map.id);

            e.ben_id = m.beneficiary_map.ben_id;
            e.mastertypeid = m.beneficiary_map.mastertypeid;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_beneficiary_choice_map.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_beneficiary_map(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_beneficiary_choice_map.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_beneficiary_choice_map.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_beneficiary_choice_map> GetAll_beneficiary_map(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_beneficiary_choice_map
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion


















    }
}
