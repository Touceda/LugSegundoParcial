using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoSQL;
using AerolineasObjetos;
using System.Data;
using System.Data.SqlClient;

namespace AerolineasImplementacion
{
    public class PasajeroLogica
    {
        AccesoPasajeros ConexionPasajeros = new AccesoPasajeros();
        Parametros Paramiters = new Parametros();

        public List<Pasajero> PasajeroLeer()
        {
            List<Pasajero> Pasajeros = new List<Pasajero>();
            try
            {
                DataTable PasajerosTabla = ConexionPasajeros.BuscarPasajeros();

                foreach (DataRow fila in PasajerosTabla.Rows)
                {
                    int dni = int.Parse(fila[0].ToString());
                    string nombre = fila[1].ToString();
                    string apellido = fila[2].ToString();
                    Pasajeros.Add(new Pasajero(dni, nombre, apellido));
                }
                return Pasajeros;
            }
            catch (Exception)
            {
                return Pasajeros;
            }
        }
        public string PasajeroAñadir(Pasajero Pasajero)
        {
            try
            {
                DataTable PasajerosTabla = ConexionPasajeros.BuscarPasajeros();

                foreach (DataRow fila in PasajerosTabla.Rows)//Reviso que no se repita el dni
                {
                    int dni = int.Parse(fila[0].ToString());
                    if (dni == Pasajero.Dni)
                    {
                        return "Ya se encontro un pasajero registrado con ese DNI";
                    }
                }

                List<SqlParameter> Parametros = new List<SqlParameter>();
                Parametros.Add(Paramiters.CrearParametro("@dni", Pasajero.Dni));
                Parametros.Add(Paramiters.CrearParametro("@nombre", Pasajero.Nombre));
                Parametros.Add(Paramiters.CrearParametro("@apellido", Pasajero.Apellido));
                if (ConexionPasajeros.AñadirPasajero(Parametros))
                {
                    return "Subscripcion Exitosa";
                }
                return "Ocurrio un error en la base de datos";
            }
            catch (Exception)
            {
                return "Ocurrio un error, intentelo mas tarde";
            }          
        }
        public string PasajeroModificar(int dni, Pasajero Pasajero,bool revisarDNI)
        {
            try
            {
                if (revisarDNI)
                {
                    DataTable PasajerosTabla = ConexionPasajeros.BuscarPasajeros();
                    foreach (DataRow fila in PasajerosTabla.Rows)//Reviso que no se repita el dni
                    {
                        int dnii = int.Parse(fila[0].ToString());
                        if (dnii == Pasajero.Dni)
                        {
                            return "El nuevo DNI ya se encuentra registrado, no es posible realizar la modificacion, intentelo mas tarde";
                        }
                    }
                }
               

                List<SqlParameter> Parametros = new List<SqlParameter>();
                Parametros.Add(Paramiters.CrearParametro("@dni", dni));
                Parametros.Add(Paramiters.CrearParametro("@dninuevo", Pasajero.Dni));
                Parametros.Add(Paramiters.CrearParametro("@nombre", Pasajero.Nombre));
                Parametros.Add(Paramiters.CrearParametro("@apellido", Pasajero.Apellido));
                ConexionPasajeros.ModificarPasajero(Parametros);
                return "Modificacion realizada con exito";
            }
            catch (Exception ex)
            {
                string x = ex.ToString();
                return "Ocurrio un error, Intentelo mas tarde";
            }        
        }
        public bool PasajeroBorrar(int dni)
        {
            try
            {
                ConexionPasajeros.BorrarPasajero(dni);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        
    }
}
