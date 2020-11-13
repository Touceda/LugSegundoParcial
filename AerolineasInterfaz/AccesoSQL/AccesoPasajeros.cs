using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoSQL
{
    public class AccesoPasajeros
    {
        Conect ConectSQL = new Conect();
       
        public DataTable BuscarPasajeros()
        {
            DataTable PasajerosTabla = new DataTable();
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand("PasajeroLeer",ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter DA = new SqlDataAdapter())
                {
                    DA.SelectCommand = comando; 
                    DA.Fill(PasajerosTabla); //Ejecuto comando
                }
            }
            ConectSQL.Desconectar();
            return PasajerosTabla;
        }
        public bool AñadirPasajero(List<SqlParameter> Parametros)
        {          
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand("PasajeroAgregar", ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(Parametros.ToArray());
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
            return true;
        }
        public void ModificarPasajero(List<SqlParameter> Parametros)
        {
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand("PasajeroModificar", ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(Parametros.ToArray());
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
        }
        public void BorrarPasajero(int dni)
        {
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand("PasajeroBorrar", ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@dni", dni);
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
        }

    }
}
