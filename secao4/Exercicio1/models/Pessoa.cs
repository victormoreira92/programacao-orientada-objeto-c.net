using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set;}

        override public string ToString()
        {
            return Nome;
        }


           
    }
}