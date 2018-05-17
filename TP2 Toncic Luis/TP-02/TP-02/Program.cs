using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_2017;

namespace TP_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Changuito changoDeCompras = new Changuito(5);

            Dulce c1 = new Dulce("ASD012", Producto.EMarca.Sancor, ConsoleColor.Black);
            Dulce c2 = new Dulce("ASD913", Producto.EMarca.Ilolay, ConsoleColor.Red);
            Leche m1 = new Leche("HJK789", Producto.EMarca.Pepsico, ConsoleColor.White);
            Leche m2 = new Leche("IOP852", Producto.EMarca.Serenisima, ConsoleColor.Blue, Leche.ETipo.Descremada);
            Snacks a1 = new Snacks("QWE968", Producto.EMarca.Campagnola, ConsoleColor.Gray);
            Snacks a2 = new Snacks("TYU426", Producto.EMarca.Arcor, ConsoleColor.DarkBlue);
            Snacks a3 = new Snacks("IOP852", Producto.EMarca.Sancor, ConsoleColor.Green);

            // Agrego 6 ítems (los últimos 2 no deberían poder agregarse) y muestro
            changoDeCompras += c1;
            changoDeCompras += c2;
            changoDeCompras += m1;
            changoDeCompras += m2;
            changoDeCompras += a1;
            changoDeCompras += a2;
            changoDeCompras += a3;

            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Quito un item y muestro
            changoDeCompras -= c1;

            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Dulces
            Console.WriteLine(changoDeCompras.Mostrar(Changuito.ETipo.Dulce));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Leches
            Console.WriteLine(changoDeCompras.Mostrar(Changuito.ETipo.Leche));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Snacks
            Console.WriteLine(changoDeCompras.Mostrar(Changuito.ETipo.Snacks));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
        }
    }
}
