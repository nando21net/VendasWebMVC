using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMVC.Models;
using VendasWebMVC.Servicos;

namespace VendasWebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedoresServico _vendedoresServico;

        public VendedoresController(VendedoresServico vendedoresServico)
        {
            _vendedoresServico = vendedoresServico;
        }
        public IActionResult Index()
        {
            var list = _vendedoresServico.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedoresServico.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
