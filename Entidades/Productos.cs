using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panaderia.Entidades
{
    internal class Productos
    {
        public Productos(int id,string nombre, string description,double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.description = description;
            this.precio = precio;
        }

        public Productos()
        {
            Producto = new List<Productos>();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string description { get; set;}
        public double precio { get; set; }

        public List<Productos> Producto {  get; set; }

        public void AgregarProducto(Productos prod)
        {
            Producto.Add(prod);
        }

        public void QuitarProducto(int indice)
        {
            Producto.RemoveAt(indice);
        }

        public override string ToString()
        {
            return "Producto: "+ nombre +" | Precio: "+ precio + " | Descripcion: " + description ;
        }
    }
}
