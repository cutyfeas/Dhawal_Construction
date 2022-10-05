using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App.Entity;
using App.Models;
using App.Service;
using static System.Collections.Specialized.BitVector32;

namespace App.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Itbl_userService tbl_userService;
        Itbl_roleService tbl_roleService;
        Itbl_pageservice tbl_pageservice;
        Itbl_role_pageService tbl_role_pageservice;



        public UserController(ILogger<HomeController> logger, Itbl_userService _tbl_userService
            , Itbl_roleService _tbl_roleService, Itbl_pageservice _tbl_pageservice,
            Itbl_role_pageService _tbl_role_pageservice)
        {
            _logger = logger;
            tbl_userService = _tbl_userService;
            tbl_roleService = _tbl_roleService;
            this.tbl_pageservice = _tbl_pageservice;
            this.tbl_role_pageservice = _tbl_role_pageservice;
        }

        public async Task<IActionResult> Index(int tabid = 1)
        {
            var rolelist = new List<tbl_role>();
            var pagelist = new List<tbl_pages>();
            var rolepagelist = new List<tbl_role_page>();
            if (tabid == 1)
                rolelist = await tbl_roleService.GetAll_TblRole();
            else if (tabid == 2)
                pagelist = await tbl_pageservice.GetAll_tbl_pages();
            else if (tabid == 3)
            {
                rolepagelist = await tbl_role_pageservice.GetAll_tbl_role_page();
                rolelist = await tbl_roleService.GetAll_TblRole();
                pagelist = await tbl_pageservice.GetAll_tbl_pages();

                rolelist.Insert(0, new tbl_role { id = 0, rolename = "--Select Role Name--" });
                pagelist.Insert(0, new tbl_pages { id = 0, pagename = "--Select Page Name--" });
            }


            var model = new usermodel
            {
                tabid = tabid,
                rolelist = rolelist,
                pagelist = pagelist,
                rolepagelist = rolepagelist
            };
            return View(model);
        }

        #region role

        [Route("user/role", Name = "rolelist")]
        public async Task<IActionResult> viewrole()
        {
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> addrole(usermodel m)
        {
            if (m.roleid == 0)
                await tbl_roleService.Add_TblRole(m);
            else
                await tbl_roleService.Update_TblRole(m);
            return RedirectToAction("viewrole");
        }
        public async Task<IActionResult> deleterole(int id)
        {
            var data = await tbl_roleService.Delete_TblRole(id);
            return RedirectToAction("viewrole");
        }
        public async Task<IActionResult> editrole(int id)
        {
            var rolelist = await tbl_roleService.GetAll_TblRole();
            var role = await tbl_roleService.Get_TblRole(id);
            var model = new usermodel
            {
                tabid = 1,
                rolelist = rolelist,
                roleid = role.id,
                rolename = role.rolename
            };
            return View("Index", model);
        }

        #endregion

        #region page

        public async Task<IActionResult> viewpage()
        {

            return RedirectToAction("Index", new { tabid = 2 });
        }
        [HttpPost]
        public async Task<IActionResult> addpage(usermodel m)
        {
            if (m.pageid == 0)
                await tbl_pageservice.Add_tbl_pages(m);
            else
                await tbl_pageservice.Update_tbl_pages(m);
            return RedirectToAction("viewpage");
        }
        public async Task<IActionResult> deletepage(int id)
        {
            var data = await tbl_pageservice.Delete_tbl_pages(id);
            return RedirectToAction("viewpage");
        }
        public async Task<IActionResult> editpage(int id)
        {
            var datalist = await tbl_pageservice.GetAll_tbl_pages();
            var data = await tbl_pageservice.Get_tbl_pages(id);
            var model = new usermodel
            {
                tabid = 2,
                pagelist = datalist,
                pageid = data.id,
                pagename = data.pagename
            };
            return View("Index", model);
        }
        #endregion

        #region role page

        public async Task<IActionResult> viewrolepage()
        {
            return RedirectToAction("Index", new { tabid = 3 });
        }

        [HttpPost]
        public async Task<IActionResult> addrolepage(usermodel m)
        {
            if (m.rolepageid == 0)
                await tbl_role_pageservice.Add_tbl_role_page(m);
            else
                await tbl_role_pageservice.Update_tbl_role_page(m);
            return RedirectToAction("viewrolepage");
        }
        public async Task<IActionResult> deleterolepage(int id)
        {
            var data = await tbl_role_pageservice.Delete_tbl_role_page(id);
            return RedirectToAction("viewrolepage");
        }
        public async Task<IActionResult> editrolepage(int id)
        {
            var data = await tbl_role_pageservice.Get_tbl_role_page(id);
            var model = new usermodel
            {
                tabid = 3,
                rolelist = await tbl_roleService.GetAll_TblRole(),
                pagelist = await tbl_pageservice.GetAll_tbl_pages(),
                rolepagelist = await tbl_role_pageservice.GetAll_tbl_role_page(),
                roleid = Convert.ToInt32(data.roleid),
                pageid = Convert.ToInt32(data.pageid),
                rolepageid=id
            };
            return View("Index", model);
        }
        #endregion



        public async Task<IActionResult> viewusers()
        {
            return RedirectToAction("Index", new { tabid = 4 });
        }



        public async Task<IActionResult> Create()
        {
            var data = await tbl_userService.Add_tbl_user(null);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Create(tbl_user TblUser)
        {
            var data = await tbl_userService.Add_tbl_user(TblUser);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await tbl_userService.Get_tbl_user(id);
            return View("Create", data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(tbl_user TblUser)
        {
            await tbl_userService.Update_tbl_user(TblUser);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var data = await tbl_userService.Get_tbl_user(id);
            return View(data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var data = await tbl_userService.Delete_tbl_user(id);
            return RedirectToAction("Index");
        }





        [HttpGet]
        public async Task<IActionResult> GetAll_TblUser()
        {
            try
            {
                var data = await tbl_userService.GetAll_tbl_user();
                if (data == null)
                {
                    return NotFound();
                }

                return Ok(data);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
