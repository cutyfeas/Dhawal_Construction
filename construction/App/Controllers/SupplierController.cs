using App.Entity;
using App.Models;
using App.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ISupplierService SupplierService;




        public SupplierController(ILogger<HomeController> logger, ISupplierService
            _SupplierService
            )
        {
            _logger = logger;
            this.SupplierService = _SupplierService;
        }

        public async Task<IActionResult> Index(int tabid = 1)
        {
            var mastertypelist = new List<tbl_mastertype>();
            var masterfieldlist = new List<tbl_masterfields>();
            var mastertypefieldlist = new List<tbl_mastertypefields>();
            var supplierlist = new List<tbl_suppliers>();
            var mastertypesupplierlist = new List<tbl_mastertype_supplier_map>();



            if (tabid == 1)
                mastertypelist = await SupplierService.GetAll_mastertypelist();
            else if (tabid == 2)
                masterfieldlist = await SupplierService.GetAll_masterfieldlist();
            else if (tabid == 3)
                mastertypefieldlist = await SupplierService.GetAll_mastertypefieldlist();
            else if (tabid == 4)
                supplierlist = await SupplierService.GetAll_supplierlist();
            else if (tabid == 5)
                mastertypesupplierlist = await SupplierService.GetAll_mastertypesupplierlist();


            var model = new suppliermodel
            {
                tabid = tabid,
                mastertypelist = mastertypelist,
                masterfieldlist = masterfieldlist,
                mastertypefieldlist = mastertypefieldlist,
                supplierlist = supplierlist,
                mastertypesupplierlist = mastertypesupplierlist
            };
            return View(model);
        }

        #region viewmastertype

        public async Task<IActionResult> viewmastertype()
        {
            return RedirectToAction("Index", new { tabid = 1 });
        }
        [HttpPost]
        public async Task<IActionResult> addmastertype(suppliermodel m)
        {
            if (m.mastertype.id == 0)
                await SupplierService.Add_mastertype(m);
            else
                await SupplierService.Update_mastertype(m);
            return RedirectToAction("viewmastertype");
        }
        public async Task<IActionResult> deletemastertype(int id)
        {
            var data = await SupplierService.Delete_mastertype(id);
            return RedirectToAction("viewmastertype");
        }
        public async Task<IActionResult> editmastertype(int id)
        {
            var mastertypelist = await SupplierService.GetAll_mastertypelist();
            var mastertype = await SupplierService.GetAll_mastertype(id);
            var model = new suppliermodel
            {
                tabid = 1,
                mastertypelist = mastertypelist,
                mastertype = new tbl_mastertype
                {
                    id = mastertype.id,
                    description = mastertype.description,
                }

            };
            return View("Index", model);
        }

        #endregion


        #region viewmasterfield

        public async Task<IActionResult> viewmasterfield()
        {

            return RedirectToAction("Index", new { tabid = 2 });
        }
        [HttpPost]
        public async Task<IActionResult> addmasterfield(suppliermodel m)
        {
            if (m.masterfield.id == 0)
                await SupplierService.Add_masterfield(m);
            else
                await SupplierService.Update_masterfield(m);
            return RedirectToAction("viewmasterfield");
        }
        public async Task<IActionResult> deletemasterfield(int id)
        {
            var data = await SupplierService.Delete_masterfield(id);
            return RedirectToAction("viewmasterfield");
        }
        public async Task<IActionResult> editmasterfield(int id)
        {
            var list = await SupplierService.GetAll_masterfieldlist();
            var e = await SupplierService.GetAll_masterfield(id);
            var model = new suppliermodel
            {
                tabid = 2,
                masterfieldlist = list,
                masterfield = new tbl_masterfields
                {
                    id = e.id,
                    name = e.name,
                    datatype = e.datatype,
                }

            };
            return View("Index", model);
        }

        #endregion


        #region supplier
        public async Task<IActionResult> viewsupplier()
        {
            return RedirectToAction("Index", new { tabid = 4 });
        }
        [HttpPost]
        public async Task<IActionResult> addsupplier(suppliermodel m)
        {
            if (m.supplier.id == 0)
                await SupplierService.Add_supplier(m);
            else
                await SupplierService.Update_supplier(m);
            return RedirectToAction("viewsupplier");
        }
        public async Task<IActionResult> deletesupplier(int id)
        {
            var data = await SupplierService.Delete_supplier(id);
            return RedirectToAction("viewsupplier");
        }
        public async Task<IActionResult> editsupplier(int id)
        {
            var list = await SupplierService.GetAll_supplierlist();
            var e = await SupplierService.GetAll_supplier(id);
            var model = new suppliermodel
            {
                tabid = 4,
                supplierlist = list,
                supplier = new tbl_suppliers
                {
                    id = e.id,
                    name = e.name,
                }

            };
            return View("Index", model);
        }
        #endregion



        public async Task<IActionResult> viewmastertypefield()
        {

            return RedirectToAction("Index", new { tabid = 3 });
        }
       
        public async Task<IActionResult> viewmastertypesupplier()
        {

            return RedirectToAction("Index", new { tabid = 5 });
        }
    }
}
