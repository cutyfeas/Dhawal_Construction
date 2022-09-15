using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;
using WebApplication1.Models;
using WebApplication1.Service;
using static System.Collections.Specialized.BitVector32;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ITblUserService TblUserService;


        public UserController(ILogger<HomeController> logger, ITblUserService _TblUserService)
        {
            _logger = logger;
            TblUserService = _TblUserService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await TblUserService.GetAll_TblUser();
            return View(data);
        }
        public async Task<IActionResult> Create()
        {
            var data = await TblUserService.Get_TblUser(null);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Create(TblUser TblUser)
        {
            var data = await TblUserService.Add_TblUser(TblUser);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await TblUserService.Get_TblUser(id);
            return View("Create", data);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TblUser TblUser)
        {
            await TblUserService.Update_TblUser(TblUser);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var data = await TblUserService.Get_TblUser(id);
            return View(data);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var data = await TblUserService.Delete_TblUser(id);
            return RedirectToAction("Index");
        }





        [HttpGet]
        public async Task<IActionResult> GetAll_TblUser()
        {
            try
            {
                var data = await TblUserService.GetAll_TblUser();
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
