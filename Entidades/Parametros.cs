using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panaderia.Entidades
{
    internal class Parametros
    {
        private string nombre;
        private object valor;

        public Parametros(string nombre, object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public object Valor { get => valor; set => valor = value; }
    }
}
