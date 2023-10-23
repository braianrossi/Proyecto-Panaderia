using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Panaderia.Entidades;

namespace Proyecto_Panaderia.Datos
{
    internal class DBHelper
    {
        private SqlConnection conexion;

        public DBHelper()
        {
            conexion = new SqlConnection("Data Source=localhost;Initial Catalog=Panaderia;Integrated Security=True");
        }

        public DataTable Consultar(string nombre)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre;

            DataTable tabla = new DataTable();

            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public int actualizarBD(string consultaSQL, List<Parametros> lParametros)
        {
            int filasAfectadas;
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            comando.Parameters.Clear();
            foreach (Parametros p in lParametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }
    }
}
