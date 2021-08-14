using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoEncuesta.Models;
using System.Data.SqlClient;

namespace ProyectoEncuesta.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=DESKTOP-0MN4B7M\\BD; database=base1; integrated security= true;";
        }
        [HttpPost]
        public ActionResult Verify(Login cuenta)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from usuarios where usuario= '" + cuenta.usuario + "' and contrasenia= '" + cuenta.contra + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();

                return RedirectToAction("Index", "Encuestas");
            }
            else
            {
             
                con.Close();
                ViewBag.Mensaje = "Esto es el mensaje";
                return View("Login");
            }


        }
    }
}