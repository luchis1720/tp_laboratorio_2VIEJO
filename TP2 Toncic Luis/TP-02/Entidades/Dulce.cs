using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {
        /// <summary>
        /// constructor de la clase. por defecto
        /// </summary>
        /// <param name="marca">la marca se pasa como parametro</param>
        /// <param name="patente">el codigo de barras se pasa como parametro</param>
        /// <param name="color">el color del empaque se pasa como parametro</param>
        public Dulce(string patente, EMarca marca, ConsoleColor color) 
            : base (patente,marca,color)
        {

        }

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>retorna un string con los datos del producto</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
