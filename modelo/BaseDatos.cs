using modelo.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class BaseDatos : ConexionMysql
    {
        public List<producto> TraerProductos()
        {
            List<producto> productos = new List<producto>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM productos";
            MySqlDataReader dr = cmd.ExecuteReader();   
         

            while (dr.Read())
            {
                producto productoActual = new producto();
                productoActual.id_producto = dr.GetInt32(0);
                productoActual.nombre = dr.GetString(1);
                productoActual.descripcion = dr.GetString(2);
                productoActual.categoria = dr.GetString(3);
                productoActual.precio = dr.GetDecimal(4);
                productoActual.cantidad_stock = dr.GetInt32(5);
                productoActual.fecha_registro = dr.GetDateTime(6);
                productos.Add(productoActual);
            }

            return productos;
        }

        public int GuardarProducto(string nombre, string descripcion)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO productos (nombre,descripcion)" +
                " VALUES ('" + nombre + "','" + descripcion + "')";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
    }
}
