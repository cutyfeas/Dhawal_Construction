using App.Entity;
using App.Models;
using App.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class AppartmentController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        IAppartmentService AppartmentService;




        public AppartmentController(ILogger<HomeController> logger, IAppartmentService
            _AppartmentService
            )
        {
            _logger = logger;
            this.AppartmentService = _AppartmentService;
        }

        public async Task<IActionResult> Index(int tabid = 1)
        {
            var condominiumlist = new List<tbl_condominium>();
            var appartmentlist = new List<tbl_apartment>();

            if (tabid == 1)
                condominiumlist = await AppartmentService.GetAll_condominiumlist();
            else if (tabid == 2)
            {
                condominiumlist = await AppartmentService.GetAll_condominiumlist();
                appartmentlist = await AppartmentService.GetAll_appartmentlist();
            }

            var model = new appartmentmodel
            {
                tabid = tabid,
                condominiumlist = condominiumlist,
                apartmentlist = appartmentlist,
            };
            return View(model);
        }




        #region viewondominium

        public async Task<IActionResult> viewondominium()
        {
            return RedirectToAction("Index", new { tabid = 1 });
        }
        [HttpPost]
        public async Task<IActionResult> addcondominium(appartmentmodel m)
        {
            if (m.condominium.id == 0)
                await AppartmentService.Add_condominium(m);
            else
                await AppartmentService.Update_condominium(m);
            return RedirectToAction("viewondominium");
        }
        public async Task<IActionResult> deletecondominium(int id)
        {
            var data = await AppartmentService.Delete_condominium(id);
            return RedirectToAction("viewondominium");
        }
        public async Task<IActionResult> editcondominium(int id)
        {
            var list = await AppartmentService.GetAll_condominiumlist();
            var e = await AppartmentService.GetAll_condominium(id);
            var model = new appartmentmodel
            {
                tabid = 1,
                condominiumlist = list,
                condominium = new tbl_condominium
                {
                    id = e.id,
                    condominium_name = e.condominium_name,
                    address = e.address,
                    location = e.location,
                    taxcode = e.taxcode,
                    vatnumber = e.vatnumber,
                    administrator = e.administrator,
                    lat = e.lat,
                    lng = e.lng,
                    buildings = e.buildings,
                    users = e.users,
                }

            };
            return View("Index", model);
        }

        #endregion


        #region viewappartment

        public async Task<IActionResult> viewappartment()
        {

            return RedirectToAction("Index", new { tabid = 2 });
        }
        [HttpPost]
        public async Task<IActionResult> addappartment(appartmentmodel m)
        {
            if (m.apartment.id == 0)
                await AppartmentService.Add_appartment(m);
            else
                await AppartmentService.Update_appartment(m);
            return RedirectToAction("viewappartment");
        }
        public async Task<IActionResult> deleteappartment(int id)
        {
            var data = await AppartmentService.Delete_appartment(id);
            return RedirectToAction("viewappartment");
        }
        public async Task<IActionResult> editappartment(int id)
        {
            var list = await AppartmentService.GetAll_appartmentlist();
            var e = await AppartmentService.GetAll_appartment(id);
            var model = new appartmentmodel
            {
                tabid = 2,
                condominiumlist = await AppartmentService.GetAll_condominiumlist(),
                apartmentlist = list,
                apartment = new tbl_apartment
                {
                    id = e.id,
                    condominiumid = e.condominiumid,
                    code = e.code,
                    building = e.building,
                    staircase = e.staircase,
                    floorplan = e.floorplan,
                    area = e.area,
                    fixtures = e.fixtures,
                }

            };
            return View("Index", model);
        }

        #endregion
    }
}
