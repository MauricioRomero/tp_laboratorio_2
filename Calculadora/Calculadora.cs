using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    class Calculadora
    {
        #region Methods
        private static string ValidarOperador(string operador)
        {
            if (operador=="+" || operador =="-" || operador=="*" || operador=="/")
            {
                return operador;
            }

            return "+";
        }
        public double Operar(Numero num1, Numero num2, String operador)
        {
            double rtaNum = 0;
            Calculadora.ValidarOperador(operador);
            switch (operador)
            {
                case "+":
                    rtaNum = num1 + num2;
                    break;
                case "-":
                    rtaNum = num1 - num2;
                    break;
                case "*":
                    rtaNum = num1 * num2;
                    break;
                case "/":
                    rtaNum = num1 / num2;
                    break;
                default:
                    Console.WriteLine("?");
                    break;
            }

            return rtaNum;
        }
        #endregion
    }
}
