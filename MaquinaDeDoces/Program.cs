using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlProduto controlProd = new ControlProduto();


            //chamar o metodo principal daquela classe
            controlProd.Operacao();

            Console.ReadLine(); // Manter a janela aberta # como se fosse o leia no portugol
        }// fim do metodo main
    }// fim da classe

}

