using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoSQL
{
    public class Conect
    {
        private SqlConnection conexion;
        public SqlConnection Conexion { get { return conexion; } }

        private string sqlDirecction = @"Data Source=DESKTOP-4EMC1D1;Initial Catalog=Aerolineas;Integrated Security=True";

        public SqlConnection Conectar()
        {
            //Evita crear una nueva conexion cunado ya tenemos una activa
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                return conexion;
            }

            conexion = new SqlConnection();
            conexion.ConnectionString = sqlDirecction;
            conexion.Open();
            return conexion;
        }
        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
            GC.Collect();
        }

    }
}
