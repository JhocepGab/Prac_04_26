using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class ListaInventario
    {
        public Nodo primero = null;

        public void Insertar(int id, string nom, int cantidad)
        {
            Nodo nuevo = new Nodo();
            //primero no es igual -- primero es la clase --- el ultimo es la herramienta
            nuevo.id = id;
            nuevo.nombre = nom;
            nuevo.stock = cantidad;
            nuevo.ventas = 0; 
            nuevo.sig = null;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temp = primero;
                while (temp != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public void Mostrar()
        {
            Nodo temp = primero;
            while (temp != null)
            {
                Console.WriteLine("ID: " + temp.id + " | Prod: " + temp.nombre + " | Stock: " + temp.stock);
                temp = temp.sig;
            }
        }
        public void Vender (int idbusque, int cantidad)
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (temp.id == idbusque)
                {
                    if (temp.stock >= cantidad)
                    {
                        temp.stock = temp.stock - cantidad;
                        temp.ventas = temp.ventas + cantidad;
                        Console.WriteLine("Venta realizada");
                    }
                    else
                    {
                        Console.WriteLine("Falta de stock");
                    }
                    return;
                }
                temp = temp.sig;
            }
            Console.WriteLine("producto no encontrado");
        }
        public void MosProMasVendido()
        {
            if (primero == null)
            {
                Console.WriteLine("Inventario vacio.");
                return;
            }

            Nodo temp = primero;
            Nodo mayor = primero;

            while (temp != null)
            {
                if (temp.ventas > mayor.ventas)
                {
                    mayor = temp;
                }
                temp = temp.sig;
            }

            Console.WriteLine("Producto mas vendido: " + mayor.nombre + " (Ventas: " + mayor.ventas + ")");
        }
    }
}
