using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta //precisa implementar classe abstrata, a override creditar
    {
        public override void Creditar(decimal valor){ 
            
            saldo += valor;
        }
        
    }
}