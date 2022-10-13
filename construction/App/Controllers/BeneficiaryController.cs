using App.Entity;
using App.Models;
using App.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class BeneficiaryController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        IAppartmentService AppartmentService;
        IBeneficiaryService BeneficiaryService;
        ISupplierService SupplierService;




        public BeneficiaryController(ILogger<HomeController> logger, IAppartmentService
            _AppartmentService, IBeneficiaryService _BeneficiaryService, ISupplierService _SupplierService
            )
        {
            _logger = logger;
            this.AppartmentService = _AppartmentService;
            this.BeneficiaryService = _BeneficiaryService;
            this.SupplierService = _SupplierService;
        }
        public async Task<IActionResult> Index(int tabid = 1)
        {
            var condominiumlist = new List<tbl_condominium>();
            var appartmentlist = new List<tbl_apartment>();
            var beneficiarylist = new List<tbl_beneficiary>();
            var beneficiary_maplist = new List<tbl_beneficiary_choice_map>();
            var mastertypelist = new List<tbl_mastertype>();

            if (tabid == 1)
            {
                beneficiarylist = await BeneficiaryService.GetAll_beneficiarylist();
                condominiumlist = await AppartmentService.GetAll_condominiumlist();
                appartmentlist = await AppartmentService.GetAll_appartmentlist();

            }
            else if (tabid == 2)
            {
                beneficiary_maplist = await BeneficiaryService.GetAll_beneficiary_maplist();
                beneficiarylist = await BeneficiaryService.GetAll_beneficiarylist();
                mastertypelist = await SupplierService.GetAll_mastertypelist();
            }

            var model = new beneficiarymodel
            {
                tabid = tabid,
                beneficiarylist = beneficiarylist,
                beneficiary_maplist = beneficiary_maplist,
                condominiumlist = condominiumlist,
                appartmentlist = appartmentlist,
                mastertypelist = mastertypelist,
            };
            return View(model);
        }



        #region viewbeneficiary
        public async Task<IActionResult> viewbeneficiary()
        {
            return RedirectToAction("Index", new { tabid = 1 });
        }
        [HttpPost]
        public async Task<IActionResult> addbeneficiary(beneficiarymodel m)
        {
            if (m.beneficiary.id == 0)
                await BeneficiaryService.Add_beneficiary(m);
            else
                await BeneficiaryService.Update_beneficiary(m);
            return RedirectToAction("viewbeneficiary");
        }
        public async Task<IActionResult> deletebeneficiary(int id)
        {
            var data = await BeneficiaryService.Delete_beneficiary(id);
            return RedirectToAction("viewbeneficiary");
        }
        public async Task<IActionResult> editbeneficiary(int id)
        {
            var list = await BeneficiaryService.GetAll_beneficiarylist();
            var e = await BeneficiaryService.GetAll_beneficiary(id);
            var model = new beneficiarymodel
            {
                tabid = 1,
                beneficiarylist = list,
                condominiumlist = await AppartmentService.GetAll_condominiumlist(),
                appartmentlist = await AppartmentService.GetAll_appartmentlist(),

                beneficiary = new tbl_beneficiary
                {
                    id = e.id,
                    apartmentid = e.apartmentid,
                    clientid = e.clientid,
                    condominiumid = e.condominiumid,
                    firstname = e.firstname,
                    lastname = e.lastname,
                    taxcode = e.taxcode,
                    email = e.email,
                    phone = e.phone,
                    Sheet = e.Sheet,
                    Parcel = e.Parcel,
                    Subdivision = e.Subdivision,
                    building = e.building,
                    staircase = e.staircase,
                    interior = e.interior,
                    cadastralcategory = e.cadastralcategory,
                    sqm = e.sqm,
                }

            };
            return View("Index", model);
        }

        #endregion


        #region viewbeneficiary_map

        public async Task<IActionResult> viewbeneficiary_map()
        {
            return RedirectToAction("Index", new { tabid = 2 });
        }
        [HttpPost]
        public async Task<IActionResult> addbeneficiary_map(beneficiarymodel m)
        {
                if (m.beneficiary_map.id == 0)
                    await BeneficiaryService.Add_beneficiary_map(m);
                else
                    await BeneficiaryService.Update_beneficiary_map(m);
                return RedirectToAction("viewbeneficiary_map");
        }
        public async Task<IActionResult> deletebeneficiary_map(int id)
        {
            var data = await BeneficiaryService.Delete_beneficiary_map(id);
            return RedirectToAction("viewbeneficiary_map");
        }
        public async Task<IActionResult> editbeneficiary_map(int id)
        {
            var list = await BeneficiaryService.GetAll_beneficiary_maplist();
            var e = await BeneficiaryService.GetAll_beneficiary_map(id);
            var model = new beneficiarymodel
            {
                tabid = 2,
                beneficiary_maplist = await BeneficiaryService.GetAll_beneficiary_maplist(),
                beneficiarylist = await BeneficiaryService.GetAll_beneficiarylist(),
                mastertypelist = await SupplierService.GetAll_mastertypelist(),
                beneficiary_map = new tbl_beneficiary_choice_map
                {
                    id = e.id,
                    ben_id = e.ben_id,
                    mastertypeid = e.mastertypeid,
                }

            };
            return View("Index", model);
        }

        #endregion
    }
}
