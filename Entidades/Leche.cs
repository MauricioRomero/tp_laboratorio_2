﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2017
{
   public class Leche : Producto
    {

        public enum ETipo { Entera, Descremada }
     
        #region fields
        ETipo _tipo;
        #endregion

        #region Constructores
        
        
        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche (EMarca marca, string codigo, ConsoleColor color)
            :base(codigo,marca,color)
        {
            this._tipo = ETipo.Entera;
        }

        public Leche (EMarca marca, string codigo, ConsoleColor color,ETipo tipo)
            :this(marca,codigo,color)
        {
            this._tipo = tipo;
        }
        #endregion

        #region Props
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }
        #endregion


        #region MEthods
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this._tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}