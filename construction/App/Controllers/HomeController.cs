using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using App.Service;
using Microsoft.AspNetCore.Http;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IAccountService AccountService;


        public HomeController(ILogger<HomeController> logger, IAccountService _AccountService)
        {
            _logger = logger;
            AccountService = _AccountService;
        }

        #region Login
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(loginmodel m)
        {
            var result = await AccountService.login(m);
            if (string.IsNullOrEmpty(result.error))
            {
                HttpContext.Session.SetString("token", result.AccessToken);
                HttpContext.Session.SetInt32("userid", result.userid);
                HttpContext.Session.SetString("roleid", result.roleid.ToString());

                if (result.roleid == 1)
                    return RedirectToRoute("rolelist");
                else
                    return RedirectToRoute("rolelist");
                //return RedirectToRoute("AddEditUser", new { result.Data.Id });
            }
            else
            {
                TempData["Message"] = result.error;
            }
            return RedirectToAction("Index");
        }

        #endregion

        #region Logout
        public ActionResult Logout()
        {
            HttpContext.Session.SetString("token", null);
            HttpContext.Session.Clear();
            return RedirectToRoute("login");
        }
        #endregion


        #region Register

        [Route("home/register", Name = "Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("home/register", Name = "Register")]
        public async Task<IActionResult> Register(loginmodel m)
        {
            if (ModelState.IsValid)
            {
                var result = await AccountService.Register(m);
                TempData["Message"] = result;
                return RedirectToAction("Index");
            }
            return View();
        }

        #endregion




        //[HttpGet]
        //[Route("GetUsers")]
        //public async Task<IActionResult> GetCategories()
        //{
        //    try
        //    {
        //        var categories = await TblUserService.GetAll_TblUser();
        //        if (categories == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(categories);
        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest();
        //    }

        //}










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
