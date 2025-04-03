using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2.entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set;}

        public Funcionario(string nome, decimal salario){
            this.Nome = nome;
            this.Salario = salario;
        }


    }
}