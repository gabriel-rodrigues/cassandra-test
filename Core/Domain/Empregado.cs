using System;

namespace Core.Domain
{
    public class Empregado
    {
        public Guid Id { get; set; }
        public string Cidade { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public double Salario { get; set; }


        public override string ToString()
        {
            var stringFormatada =
                $"Identificador: {Id}, Nome: {Nome}, Cidade: {Cidade}, Telefone: {Telefone}, Salario: {Salario}";

            return stringFormatada;
        }
    }
}