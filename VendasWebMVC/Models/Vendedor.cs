using System;
using System.Collections.Generic;
using System.Linq;


namespace VendasWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email{ get; set; }
        public DateTime DataAniversario { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        public Vendedor()
        { }

        public Vendedor(int id, string nome, string email, DateTime dataAniversario, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVenda(Vendas sr)
        {
            Vendas.Add(sr);
        }
        public void RemoveVenda(Vendas sr)
        {
            Vendas.Remove(sr);
        }
        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendas.Where(sr => sr.Date > initial && sr.Date <= final).Sum(sr => sr.total);
        }
    }
}
