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
            {
                mastertypelist = await SupplierService.GetAll_mastertypelist();
                mastertypelist.Insert(0, new tbl_mastertype { id = 0, description = "--Select--" });
                masterfieldlist = await SupplierService.GetAll_masterfieldlist();
                masterfieldlist.Insert(0, new tbl_masterfields { id = 0, name = "--Select--" });

                mastertypefieldlist = await SupplierService.GetAll_mastertypefieldlist();
            }
            else if (tabid == 4)
                supplierlist = await SupplierService.GetAll_supplierlist();
            else if (tabid == 5)
            {
                mastertypelist = await SupplierService.GetAll_mastertypelist();
                mastertypelist.Insert(0, new tbl_mastertype { id = 0, description = "--Select--" });
                supplierlist = await SupplierService.GetAll_supplierlist();
                supplierlist.Insert(0, new tbl_suppliers { id = 0, name = "--Select--" });

                mastertypesupplierlist = await SupplierService.GetAll_mastertypesupplierlist();
            }


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

        #region viewmastertypefield

        public async Task<IActionResult> viewmastertypefield()
        {
            return RedirectToAction("Index", new { tabid = 3 });
        }
        [HttpPost]
        public async Task<IActionResult> addmastertypefield(suppliermodel m)
        {
            if (m.mastertypefield.id == 0)
                await SupplierService.Add_mastertypefield(m);
            else
                await SupplierService.Update_mastertypefield(m);
            return RedirectToAction("viewmastertypefield");
        }
        public async Task<IActionResult> deletemastertypefield(int id)
        {
            var data = await SupplierService.Delete_mastertypefield(id);
            return RedirectToAction("viewmastertypefield");
        }
        public async Task<IActionResult> editmastertypefield(int id)
        {
            var list = await SupplierService.GetAll_mastertypefieldlist();
            var e = await SupplierService.GetAll_mastertypefield(id);
            var model = new suppliermodel
            {
                tabid = 3,
                mastertypefieldlist = list,
                mastertypelist = await SupplierService.GetAll_mastertypelist(),
                masterfieldlist = await SupplierService.GetAll_masterfieldlist(),
                mastertypefield = new tbl_mastertypefields
                {
                    id = e.id,
                    mastertypeid = e.mastertypeid,
                    masterfieldid = e.masterfieldid,
                }

            };
            return View("Index", model);
        }

        #endregion


        #region viewsupplier
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


        #region viewmastertypesupplier
        public async Task<IActionResult> viewmastertypesupplier()
        {

            return RedirectToAction("Index", new { tabid = 5 });
        }
        [HttpPost]
        public async Task<IActionResult> addmastertypesupplier(suppliermodel m)
        {
            if (m.mastertypesupplier.id == 0)
                await SupplierService.Add_mastertypesupplier(m);
            else
                await SupplierService.Update_mastertypesupplier(m);
            return RedirectToAction("viewmastertypesupplier");
        }
        public async Task<IActionResult> deletemastertypesupplier(int id)
        {
            var data = await SupplierService.Delete_mastertypesupplier(id);
            return RedirectToAction("viewmastertypesupplier");
        }
        public async Task<IActionResult> editmastertypesupplier(int id)
        {
            var list = await SupplierService.GetAll_mastertypesupplierlist();
            var e = await SupplierService.GetAll_mastertypesupplier(id);
            var model = new suppliermodel
            {
                tabid = 5,
                mastertypelist = await SupplierService.GetAll_mastertypelist(),
                supplierlist = await SupplierService.GetAll_supplierlist(),
                mastertypesupplierlist = list,

                mastertypesupplier = new tbl_mastertype_supplier_map
                {
                    id = e.id,
                    mastertypeid = e.mastertypeid,
                    supplierid = e.supplierid,
                    quotedvalue = e.quotedvalue,
                }

            };
            return View("Index", model);
        }
        #endregion



    }
}
