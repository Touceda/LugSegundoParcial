using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoSQL
{
    public class AccesoVuelos
    {
        Conect ConectSQL = new Conect();
        public DataTable BuscarVuelos(bool isComun)
        {
            DataTable VuelosTabla = new DataTable();
            ConectSQL.Conectar();

            if (isComun)
            {
                using (SqlCommand comando = new SqlCommand("VueloComunLeer", ConectSQL.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter DA = new SqlDataAdapter())
                    {
                        DA.SelectCommand = comando;
                        DA.Fill(VuelosTabla); //Ejecuto comando
                    }
                }
            }
            else
            {

            }
                 
           
            ConectSQL.Desconectar();
            return VuelosTabla;
        }
        //public bool AñadirDestino(List<SqlParameter> Parametros)
        //{
        //    ConectSQL.Conectar();
        //    using (SqlCommand comando = new SqlCommand("DestinoAgregar", ConectSQL.Conexion))
        //    {
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.AddRange(Parametros.ToArray());
        //        comando.ExecuteNonQuery();
        //    }
        //    ConectSQL.Desconectar();
        //    return true;
        //}
        //public void ModificarDestino(List<SqlParameter> Parametros)
        //{
        //    ConectSQL.Conectar();
        //    using (SqlCommand comando = new SqlCommand("DestinoModificar", ConectSQL.Conexion))
        //    {
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.AddRange(Parametros.ToArray());
        //        comando.ExecuteNonQuery();
        //    }
        //    ConectSQL.Desconectar();
        //}
        //public void BorrarDestino(int id)
        //{
        //    ConectSQL.Conectar();
        //    using (SqlCommand comando = new SqlCommand("DestinoBorrar", ConectSQL.Conexion))
        //    {
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.AddWithValue("@id", id);
        //        comando.ExecuteNonQuery();
        //    }
        //    ConectSQL.Desconectar();
        //}
    }
}
