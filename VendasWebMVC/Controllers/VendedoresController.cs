﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMVC.Models;
using VendasWebMVC.Models.ViewModels;
using VendasWebMVC.Servicos;
//using VendasWebMVC.Servicos.Exceptions;



namespace VendasWebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedoresServico _vendedoresServico;
        private readonly DepartamentoServico _departamentoServico;

        public VendedoresController(VendedoresServico vendedoresServico, DepartamentoServico departamentoServico)
        {
            _vendedoresServico = vendedoresServico;
            _departamentoServico = departamentoServico;
        }
        public IActionResult Index()
        {
            var list = _vendedoresServico.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departamentos = _departamentoServico.FindAll();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };
            return View(viewModel);
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
