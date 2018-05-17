using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// La clase Producto será abstracta, evitando que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        EMarca marca;
        string codigoDeBarras;
        ConsoleColor colorPrimarioEmpaque;

        /// <summary>
        /// Constructor de la clase. por defecto
        /// </summary>
        /// <param name="codigo">codigo de barras pasado como parametro</param>
        /// <param name="marca">nombre de la marca pasada como parametro</param>
        /// <param name="color">color del empaque pasado como parametro</param>
        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras=codigo;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }
        



        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
        protected abstract short CantidadCalorias { get; }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>retorna un string con los datos del producto</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }



        /// <summary>
        /// Retorna los datos del producto recibido
        /// </summary>
        /// <param name="p">Producto se pasa como paramtro</param>
        /// <returns>un string con los datos del producto recibido</returns>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CODIGO DE BARRAS: {0}\r\n", p.codigoDeBarras);
            sb.AppendFormat("MARCA          : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR EMPAQUE  : {0}\r\n", p.colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1">el producto se pasa como parametro</param>
        /// <param name="v2">el producto se pasa como parametro</param>
        /// <returns>retorna true si son iguales o false si son distintos</returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1.codigoDeBarras == v2.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto (SE REUTILIZA CODIGO)
        /// </summary>
        /// <param name="v1">el producto se pasa como parametro</param>
        /// <param name="v2">el producto se pasa como parametro</param>
        /// <returns>retorna true si son distintos o false si son iguales</returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1 == v2);
        }
    }
}
