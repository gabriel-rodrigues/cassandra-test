using System;

namespace WebApplication.Models
{
    public class EmpregadoViewModel
    {
        public Guid Id { get; set; }
        public string Cidade { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public double Salario { get; set; }
        
    }
}