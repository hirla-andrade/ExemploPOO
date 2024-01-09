using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2); //interfaces não tem o public na frente porque por padrao subtende-se que já seja publico
        int Subtrair(int num1, int num2);//também não possui implementação nem {}, apenas a descrição dos métodos
        int Multiplicar(int num1, int num2);//métodos q n tem corpo s obrigatórios para implementação

        int Dividir(int num1, int num2){ //e métodos que tem corpo n s obrigatorios
            return num1 / num2;
        }
    }
}

//se quiser implementar a interface " ICalculadora", precisa implementar todos os métodos dentro dela