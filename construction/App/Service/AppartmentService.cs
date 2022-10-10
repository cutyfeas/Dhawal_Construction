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
    public interface IAppartmentService
    {

        Task<List<tbl_condominium>> GetAll_condominiumlist();
        Task<int> Add_condominium(appartmentmodel m);
        Task<int> Update_condominium(appartmentmodel m);
        Task<int> Delete_condominium(int id);
        Task<tbl_condominium> GetAll_condominium(int id);


        Task<List<tbl_apartment>> GetAll_appartmentlist();
        Task<int> Add_appartment(appartmentmodel m);
        Task<int> Update_appartment(appartmentmodel m);
        Task<int> Delete_appartment(int id);
        Task<tbl_apartment> GetAll_appartment(int id);
    }
    public class AppartmentService : IAppartmentService
    {
        ConAppContext db;
        //Itbl_userService tbl_userService;

        public AppartmentService(ConAppContext _db)
        {
            db = _db;
        }

        #region condominium

        public async Task<List<tbl_condominium>> GetAll_condominiumlist()
        {
            if (db != null)
            {
                return await db.tbl_condominium.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_condominium(appartmentmodel m)
        {
            var e = m.condominium;
            e.createddate = DateTime.Now;
            if (db != null)
            {
                await db.tbl_condominium.AddAsync(e);
                await db.SaveChangesAsync();

                return e.id;
            }
            return 0;
        }

        public async Task<int> Update_condominium(appartmentmodel m)
        {
            int result = 0;
            var e = await db.tbl_condominium.FirstOrDefaultAsync(x => x.id == m.condominium.id);

            e.condominium_name = m.condominium.condominium_name;
            e.address = m.condominium.address;
            e.location = m.condominium.location;
            e.zip_code = m.condominium.zip_code;
            e.taxcode = m.condominium.taxcode;
            e.vatnumber = m.condominium.vatnumber;
            e.administrator = m.condominium.administrator;
            e.lat = m.condominium.lat;
            e.lng = m.condominium.lng;
            e.buildings = m.condominium.buildings;
            e.users = m.condominium.users;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_condominium.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_condominium(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_condominium.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_condominium.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_condominium> GetAll_condominium(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_condominium
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion



        #region appartment
        public async Task<List<tbl_apartment>> GetAll_appartmentlist()
        {
            if (db != null)
            {
                return await db.tbl_apartment.ToListAsync();
            }

            return null;
        }

        public async Task<int> Add_appartment(appartmentmodel m)
        {
            var e = m.apartment;
            e.createddate = DateTime.Now;
            if (db != null)
            {
                await db.tbl_apartment.AddAsync(e);
                await db.SaveChangesAsync();

                return e.id;
            }
            return 0;
        }

        public async Task<int> Update_appartment(appartmentmodel m)
        {
            int result = 0;
            var e = await db.tbl_apartment.FirstOrDefaultAsync(x => x.id == m.apartment.id);

            e.condominiumid = m.apartment.condominiumid;
            e.code = m.apartment.code;
            e.building = m.apartment.building;
            e.staircase = m.apartment.staircase;
            e.floorplan = m.apartment.floorplan;
            e.area = m.apartment.area;
            e.fixtures = m.apartment.fixtures;
            e.updateddate = System.DateTime.Now;


            if (db != null)
            {
                //Delete that data
                db.tbl_apartment.Update(e);
                //Commit the transaction
                await db.SaveChangesAsync();
                return e.id;
            }
            return result;
        }

        public async Task<int> Delete_appartment(int id)
        {
            int result = 0;

            if (db != null)
            {
                //Find the data for specific data id
                var e = await db.tbl_apartment.FirstOrDefaultAsync(x => x.id == id);

                if (e != null)
                {
                    //Delete that data
                    db.tbl_apartment.Remove(e);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task<tbl_apartment> GetAll_appartment(int id)
        {
            if (db != null)
            {
                return await (from p in db.tbl_apartment
                              where p.id == id
                              select p).FirstOrDefaultAsync();
            }

            return null;
        }
        #endregion


















    }
}
