using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WebApplication.Models
{
    public class EmpregadoViewModel
    {
        [Required(ErrorMessage = "Campo obrigatorio.")]
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio.")]
        [JsonProperty(PropertyName = "cidade")]
        public string Cidade { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio.")]
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio.")]
        [JsonProperty(PropertyName = "telefone")]
        public string Telefone { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatorio.")]
        [JsonProperty(PropertyName = "salario")]
        public double Salario { get; set; }
        
    }
}