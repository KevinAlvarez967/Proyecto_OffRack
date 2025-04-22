using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Proyecto_GoShopping
{
    class ConexionBD
    {
        private MySqlConnection conexion;
        private string cadenaConexion = "server=localhost; database=inventario_goshopping; user=root; password=;";

        public MySqlConnection Conectar()
        {
            try
            {
                if (conexion == null)
                    conexion = new MySqlConnection(cadenaConexion);

                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();

                return conexion;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public void Desconectar()
        {
            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }

    }
}
