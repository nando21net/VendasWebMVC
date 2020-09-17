using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace VendasWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name ="Data Aniversário")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataAniversario { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Salario Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

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
