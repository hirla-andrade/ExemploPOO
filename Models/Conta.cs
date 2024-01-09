using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo; //protegido contra alterações externas com excessão a suas classes filhas

        public abstract void Creditar(decimal valor); 

        public void ExibirSaldo(){
            Console.WriteLine("O seu saldo é:" + saldo);
        }
    }
}