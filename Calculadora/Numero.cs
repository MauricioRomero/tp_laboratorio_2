using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double _numero;

        #region Properties
        public String  SetNumero { set { this._numero = ValidarNumero(value); } }

        #endregion

        #region Methods
        private Double ValidarNumero(String strNumero)
        {
            int i = 0;
            if (int.TryParse(strNumero, out i))
            {
                return (Double)i;
            }
            return (Double)i;
        }
        #region Constructores

        public Numero()
        {

        }

        public Numero(double numero)
        {
            this._numero = numero;
        }
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        #endregion

        #region Convertidores

        public string BinarioDecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            // Invertido ya que los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                //Valida valores validos
                if (array[i] != '1')
                {
                    if (array[i] != '0')
                    {
                        return "Valor invalido";
                    }
                }

                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                }
            }
            return sum.ToString();

        }

        public string DecimalBinario(double numero)
        {

            string binarioRta = "";

            if (numero>0)
            {
                while (numero > 0)
                {
                    if (numero%2==0)
                    {
                        binarioRta = "0" + binarioRta;
                    }
                    else
                    {
                        binarioRta = "1" + binarioRta;
                    }
                    numero = (int)numero / 2;
                }
            }
            else if (numero==0)
            {
                binarioRta = "0";
            }
            return binarioRta;
        }
        public string DecimalBinario(String numero)
        {
            double rta = 0;
            string binarioRta = "";
            if(Double.TryParse(numero,out rta))
            {
                binarioRta = this.DecimalBinario(rta);
            }
            

            return binarioRta;
        }

        #endregion //Converters
        #region Operadores

        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2._numero == 0)
            {
                Console.WriteLine("Error. No se puede dividir por cero.");
                return 0;
            }
            return n1._numero / n2._numero;

        }

        #endregion //Methods

#endregion

    }
}
