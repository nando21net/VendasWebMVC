using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMVC.Models;
using VendasWebMVC.Models.ViewModels;

namespace VendasWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        { 
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1 , Nome = "Eletronicos"});
            list.Add(new Departamento { Id = 2, Nome = "Roupas"});

            return View(list);
        }
    }
}
