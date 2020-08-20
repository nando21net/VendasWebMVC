using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Data;
using VendasWebMVC.Models;

namespace VendasWebMVC.Servicos
{
    public class VendedoresServico
    {
        private readonly VendasWebMVCContext _context;

        public VendedoresServico(VendasWebMVCContext context)
        {
            _context = context;

        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}
