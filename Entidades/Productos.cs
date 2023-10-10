using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panaderia.Entidades
{
    internal class Productos
    {
        public Productos(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;

        }

        public Productos()
        {
            Producto = new List<Productos>();
        }


        public int id { get; set; } 
        public string name { get; set; }
        public string description { get; set;}
        public List<Productos> Producto {  get; set; }

        public void AgregarProducto(Productos prod)
        {
            Producto.Add(prod);
        }
        public void QuitarProducto(int indice)
        {
            Producto.RemoveAt(indice);
        }
    }
}
