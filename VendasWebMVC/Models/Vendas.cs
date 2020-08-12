using System;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Models
{
    public class Vendas
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double total { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public Vendas() { 
        }

        public Vendas(int id, DateTime date, double total, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            this.total = total;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
