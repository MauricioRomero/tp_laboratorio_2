﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {

        #region Constructores
        
        public Dulce(EMarca marca, string codigo, ConsoleColor color)
            :base(codigo,marca,color)
        {
        }
        
        #endregion
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        ///
        protected override short CantidadCalorias
        {
            get { return 80; }
        }
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
