using Listas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_04_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaInventario milista = new ListaInventario();
            int op = 0;
            do 
            {
                Console.Clear();
                Console.WriteLine("--- INVENTARIO ---");
                Console.WriteLine("1. Mostrar inventario");
                Console.WriteLine("2. Insertar producto");
                Console.WriteLine("3. Vender producto");
                Console.WriteLine("4. Ver mas vendido");
                Console.WriteLine("5. Salir");
                Console.Write("Opcion: ");

                op = int.Parse(Console.ReadLine());

                Console.WriteLine();
                switch (op)
                {
                    case 1:
                    milista.Mostrar();
                    break;

                case 2:
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nombre: ");
                    string nom = Console.ReadLine();
                    Console.Write("Stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    milista.Insertar(id, nom, stock);
                    Console.WriteLine("Producto agregado correctamente.");
                    break;

                case 3:
                    Console.Write("ID del producto a vender: ");
                    int idVenta = int.Parse(Console.ReadLine());
                    Console.Write("Cantidad: ");
                    int cant = int.Parse(Console.ReadLine());
                    milista.Vender(idVenta, cant);
                    break;

                case 4:
                    milista.MosProMasVendido();
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
                }
                Console.ReadKey();

            } while (op != 5);
        }
    }
}
