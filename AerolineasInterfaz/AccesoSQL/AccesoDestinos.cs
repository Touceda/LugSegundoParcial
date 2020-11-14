using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoSQL
{
    public class AccesoDestinos
    {
        Conect ConectSQL = new Conect();
        public DataTable BuscarDestinos()
        {
            DataTable DestinoTabla = new DataTable();
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand("DestinoLeer", ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter DA = new SqlDataAdapter())
                {
                    DA.SelectCommand = comando;
                    DA.Fill(DestinoTabla); //Ejecuto comando
                }
            }
            ConectSQL.Desconectar();
            return DestinoTabla;
        }
        public bool AñadirDestino(List<SqlParameter> Parametros)
        {
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand("DestinoAgregar", ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(Parametros.ToArray());
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
            return true;
        }
        public void ModificarDestino(List<SqlParameter> Parametros)
        {
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand("DestinoModificar", ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(Parametros.ToArray());
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
        }
        public void BorrarDestino(int id)
        {
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand("DestinoBorrar", ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
        }

    }
}
