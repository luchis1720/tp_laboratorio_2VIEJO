using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        List<Producto> productos;
        int espacioDisponible;
        
        public enum ETipo
        {
            Dulce,
            Leche, 
            Snacks,
            Todos
        }

        #region "Constructores"
        
        /// <summary>
        /// constructor de la clase. por defecto. inicializa la lista. privado
        /// </summary>
        private Changuito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// constructor que establece el espacio disponible
        /// </summary>
        /// <param name="espacioDisponible">el lugar se pasa como parametro</param>
        public Changuito(int espacioDisponible) 
            :this()
        {
            this.espacioDisponible = espacioDisponible;
        }

        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro la concecionaria y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar(ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Mostrar(ETipo tipo) //quitar static
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", this.productos.Count,                                      this.espacioDisponible);
            sb.AppendLine("");

            foreach (Producto v in this.productos)
            {
                switch (tipo)
                {
                    case ETipo.Dulce:
                        if (v is Dulce)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Leche:
                        if (v is Leche)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Snacks:
                        if (v is Snacks)
                            sb.AppendLine(v.Mostrar());
                        break;
                    default:
                            sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns>un changuito</returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if (c.espacioDisponible > c.productos.Count())
            {
                foreach (Producto v in c.productos)
                {
                    if (v == p)
                        return c;
                }
                c.productos.Add(p);
            }          
            return c;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns>un changuito</returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto v in c.productos)
            {
                if (v == p)
                {
                    c.productos.Remove(p);
                    break;
                }
            }

            return c;
        }
        #endregion
    }
}
