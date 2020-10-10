using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore.Models;

namespace ASPCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Array array;
            List<EmpleadoModel> empleados = new List<EmpleadoModel>();
            empleados.Add(new EmpleadoModel
                {
                    NoEmpleado = "17030083",
                    Nombre = "Jaqueline",
                    Apellido = "Fernandez",
                    Departamento = "Limpieza",
                    FechaIngreso = DateTime.Now,
                    NoProducto = "102"
                });

             empleados.Add(new EmpleadoModel
                {
                    NoEmpleado = "17030084",
                    Nombre = "Sandra",
                    Apellido = "Maldonado",
                    Departamento = "Ventas",
                    FechaIngreso = DateTime.Now,
                    NoProducto = "103"
                });

             empleados.Add(new EmpleadoModel
                {
                    NoEmpleado = "17030085",
                    Nombre = "Nicolas",
                    Apellido = "Gurrola",
                    Departamento = "Gerencia",
                    FechaIngreso = DateTime.Now,
                    NoProducto = "104"
                });

               array = empleados.ToArray();

               ViewBag.EmpleadoModel = array;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
