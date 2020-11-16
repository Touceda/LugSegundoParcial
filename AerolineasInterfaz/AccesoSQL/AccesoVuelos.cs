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
                using (SqlCommand comando = new SqlCommand("VueloInternacionalLeer", ConectSQL.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter DA = new SqlDataAdapter())
                    {
                        DA.SelectCommand = comando;
                        DA.Fill(VuelosTabla); //Ejecuto comando
                    }
                }
            }              
            ConectSQL.Desconectar();
            return VuelosTabla;
        }

        public bool AñadirVuelo(List<SqlParameter> Parametros,bool isComun)
        {
            ConectSQL.Conectar();
            string proc = "VueloInternacionalAgregar";
            if (isComun)
            {
                proc = "VueloComunAgregar";
            }

            using (SqlCommand comando = new SqlCommand(proc, ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(Parametros.ToArray());
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
            return true;
        }

        public void BorrarVuelo(int id, bool isComun)
        {
            ConectSQL.Conectar();
            string proc = "VueloInternacionalBorrar";
            if (isComun)
            {
                proc = "VueloComunBorrar";
            }

            using (SqlCommand comando = new SqlCommand(proc, ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nrovuelo", id);
                comando.ExecuteNonQuery();
            }

            ConectSQL.Desconectar();
        }

        public void ModificarVuelo(List<SqlParameter> Parametros,bool isComun)
        {
            string proc = "VueloInternacionalModificar";
            if (isComun)
            {
                proc = "VueloComunModificar";
            }
            ConectSQL.Conectar();
            using (SqlCommand comando = new SqlCommand(proc, ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(Parametros.ToArray());
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
        }

        public DataTable BuscarVuelosPasajeros(bool isComun)
        {
            DataTable VuelosPasajerosTabla = new DataTable();
            ConectSQL.Conectar();

            if (isComun)
            {
                using (SqlCommand comando = new SqlCommand("VueloComunPasajeroLeer", ConectSQL.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter DA = new SqlDataAdapter())
                    {
                        DA.SelectCommand = comando;
                        DA.Fill(VuelosPasajerosTabla); //Ejecuto comando
                    }
                }
            }
            else
            {
                using (SqlCommand comando = new SqlCommand("VueloInternacionalPasajeroLeer", ConectSQL.Conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter DA = new SqlDataAdapter())
                    {
                        DA.SelectCommand = comando;
                        DA.Fill(VuelosPasajerosTabla); //Ejecuto comando
                    }
                }
            }
            ConectSQL.Desconectar();
            return VuelosPasajerosTabla;
        }

        public bool AñadirVueloPasajero(List<SqlParameter> Parametros, bool isComun)
        {
            ConectSQL.Conectar();
            string proc = "VueloInternacionalPasajeroAgregar";
            if (isComun)
            {
                proc = "VueloComunPasajeroAgregar";
            }

            using (SqlCommand comando = new SqlCommand(proc, ConectSQL.Conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(Parametros.ToArray());
                comando.ExecuteNonQuery();
            }
            ConectSQL.Desconectar();
            return true;
        }

    }
}
