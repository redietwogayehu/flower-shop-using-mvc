using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace fshop.Controllers
{
    public class flowerController : Controller
    {
        string connectionString = @"Data Source=.;Initial Catalog = MvcCRUDDB; Integrated Security= True";
        [HttpGet]
        public ActionResult Index1()
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "Select * from flower";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
            }
            return View();
        }

        // GET: flower/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult contact(int id)
        {
            return View();
        }

        // GET: flower/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: flower/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }

        // GET: flower/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: flower/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }

        // GET: flower/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: flower/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }
    }
}