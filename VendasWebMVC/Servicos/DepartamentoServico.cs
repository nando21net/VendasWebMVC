using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using VendasWebMVC.Data;


namespace VendasWebMVC.Servicos
{
    public class DepartamentoServico
    {
        private readonly VendasWebMVCContext _context;

        public DepartamentoServico(VendasWebMVCContext context)
        {
            _context = context;
        }

        public  List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
