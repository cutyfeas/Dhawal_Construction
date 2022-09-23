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


        public UserController(ILogger<HomeController> logger, Itbl_userService _tbl_userService)
        {
            _logger = logger;
            tbl_userService = _tbl_userService;
        }

        [Route("user/userlist", Name = "userlist")]
        public async Task<IActionResult> Index()
        {
            var data = await tbl_userService.GetAll_tbl_user();
            return View(data);
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
