using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fshop.Models;
using System.Data;
using System.Data.SqlClient;

namespace fshop.Controllers

{
    // [Route("product ")]
    public class HomeController : Controller
    {
        string connectionString = @"Data Source=.;Initial Catalog = flo; Integrated Security= True";
        [HttpGet]
        public IActionResult Index()
        {
            //  ViewBag.products = db.product.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Index1()
        {
            RegisterAcessLayer Users = new RegisterAcessLayer();
            List<product> lstUsers = new List<product>();
            lstUsers = Users.GetAllFlowers().ToList();

            return View(lstUsers);
        }

       

        [HttpGet]
        public IActionResult login()
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult us()
        {

            return View();
        }
        [HttpGet]
        public IActionResult about()
        {

            return View();
        }

        [HttpPost]
        public IActionResult login([Bind] Login pro)
        {
            if (ModelState.IsValid)
            {
                if (pro.userName == "elsh" && pro.Password == "1234")
                {
                    return RedirectToAction("register");


                }
                else
                {
                    return View(pro);
                }
            }
            return View();
        }


        [HttpGet]
        public IActionResult register()
        {

            return View();
        }
        public IActionResult bought()
        {

            return View();
        }
        [HttpGet]
        public IActionResult contact()
        {
            RegisterAcessLayer Users = new RegisterAcessLayer();
            List<product> lstUsers = new List<product>();
            lstUsers = Users.GetAllFlowers().ToList();

            return View(lstUsers);
        }



        [HttpPost]
        public IActionResult register(product pro)
        {
            RegisterAcessLayer registerA = new RegisterAcessLayer();
            if (ModelState.IsValid)
            {
                registerA.AddFlowers(pro);
                return RedirectToAction("Index1");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            RegisterAcessLayer Users = new RegisterAcessLayer();

            if (id == null)
            {
                return NotFound();
            }
            product reg = Users.GetUserData(id);

            if (reg == null)
            {
                return NotFound();
            }
            return View(reg);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            RegisterAcessLayer Users = new RegisterAcessLayer();

            Users.DeleteUsers(id);
            return RedirectToAction("Index1");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            RegisterAcessLayer Users = new RegisterAcessLayer();

            if (id == null)
            {
                return NotFound();
            }
            product reg = Users.GetUserData(id);

            if (reg == null)
            {
                return NotFound();
            }
            return View(reg);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]product registration)
            {
            RegisterAcessLayer Users = new RegisterAcessLayer();

            if (id != registration.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                Users.UpdateUsers(registration);
                return RedirectToAction("Index1");
            }
            return View(registration);
        }
        [HttpGet]
        public IActionResult edito(int? id)
        {
            RegisterAcessLayer Users = new RegisterAcessLayer();

            if (id == null)
            {
                return NotFound();
            }
            product reg = Users.GetUserData(id);

            if (reg == null)
            {
                return NotFound();
            }
            return View(reg);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult edito(int id, [Bind]product registration)
        {
            RegisterAcessLayer Users = new RegisterAcessLayer();

            if (id != registration.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                Users.UpdateUsers(registration);
                return RedirectToAction("bought");
            }
            return View(registration);
        }
        [HttpGet]
        public IActionResult buy()
        {
            RegisterAcessLayer Users = new RegisterAcessLayer();
            List<product> lstUsers = new List<product>();
            lstUsers = Users.GetAllFlowers().ToList();

            return View(lstUsers);
        }

    }

}


