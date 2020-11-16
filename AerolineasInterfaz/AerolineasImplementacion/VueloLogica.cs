using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineasObjetos;
using AccesoSQL;
using System.Data;
using System.Data.SqlClient;

namespace AerolineasImplementacion
{
    public class VueloLogica
    {

        AccesoVuelos ConexionVuelos = new AccesoVuelos();
        Parametros Paramiters = new Parametros();

        public List<Vuelo> VuelosComunesLeer()
        {
            List<Vuelo> Vuelos = new List<Vuelo>();
            try
            {
                DataTable VuelosTabla = ConexionVuelos.BuscarVuelos(true);

                foreach (DataRow fila in VuelosTabla.Rows)
                {
                    int nroVuelo = int.Parse(fila[0].ToString());
                    string destino = fila[1].ToString();
                    string partida = fila[2].ToString();
                    string llegada = fila[3].ToString();
                    int asientos = int.Parse(fila[4].ToString());
                    int ocupacion = int.Parse(fila[5].ToString());
                    Vuelos.Add(new Vuelo(destino, partida, llegada, asientos, ocupacion, nroVuelo));
                }
                return Vuelos;

            }        
            catch (Exception)
            {
                return Vuelos;         
            }
        }
        public List<VueloInternacional> VuelosInternacionalesLeer()
        {
            List<VueloInternacional> Vuelos = new List<VueloInternacional>();
            try
            {
                DataTable VuelosTabla = ConexionVuelos.BuscarVuelos(false);

                foreach (DataRow fila in VuelosTabla.Rows)
                {
                    int nroVuelo = int.Parse(fila[0].ToString());
                    string destino = fila[1].ToString();
                    string pais = fila[2].ToString();
                    string ciudad = fila[3].ToString();
                    string partida = fila[4].ToString();
                    string llegada = fila[5].ToString();
                    int asientos = int.Parse(fila[6].ToString());
                    int ocupacion = int.Parse(fila[7].ToString());
                    Vuelos.Add(new VueloInternacional(destino, partida, llegada, asientos, pais, ciudad, nroVuelo, ocupacion));
                }
                return Vuelos;
            }
            catch (Exception)
            {
                return Vuelos;
            }
        }
         

        public string VueloAñadir(Vuelo Vuelo = null, VueloInternacional VueloInternacional = null)
        {
            try
            {
                List<SqlParameter> Parametros = new List<SqlParameter>();
                if (Vuelo!=null)
                {
                    Parametros.Add(Paramiters.CrearParametro("@destino", Vuelo.LugarDestino));
                    Parametros.Add(Paramiters.CrearParametro("@partida", Vuelo.Partida));
                    Parametros.Add(Paramiters.CrearParametro("@llegada", Vuelo.Llegada));
                    Parametros.Add(Paramiters.CrearParametro("@asientosdisponibles", Vuelo.asientos));
                    Parametros.Add(Paramiters.CrearParametro("@porcentajedeocupacion", Vuelo.ocupacion));

                    if (ConexionVuelos.AñadirVuelo(Parametros, true))
                    {
                        return "Vuelo registrado Exitosamente";
                    }
                }
                else
                {
                    Parametros.Add(Paramiters.CrearParametro("@destino", VueloInternacional.LugarDestino));
                    Parametros.Add(Paramiters.CrearParametro("@pais", VueloInternacional.Pais));
                    Parametros.Add(Paramiters.CrearParametro("@ciudad", VueloInternacional.Ciudad));
                    Parametros.Add(Paramiters.CrearParametro("@partida", VueloInternacional.Partida));
                    Parametros.Add(Paramiters.CrearParametro("@llegada", VueloInternacional.Llegada));
                    Parametros.Add(Paramiters.CrearParametro("@asientosdisponibles", VueloInternacional.asientos));
                    Parametros.Add(Paramiters.CrearParametro("@porcentajedeocupacion", VueloInternacional.ocupacion));

                    if (ConexionVuelos.AñadirVuelo(Parametros, false))
                    {
                        return "Vuelo registrado Exitosamente";
                    }
                }
             
                return "Ocurrio algun error en la base de datos";
            }
            catch (Exception)
            {
                return "Ocurrio un error, intentelo mas tarde";
            }
        }

        public bool VueloBorrar(int id, bool isComun)
        {
            try
            {
                ConexionVuelos.BorrarVuelo(id, isComun);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void VuelosModificar(int nroVuelo, int ocupacion ,bool isComun)
        {
            try
            {
                List<SqlParameter> Parametros = new List<SqlParameter>();
                Parametros.Add(Paramiters.CrearParametro("@nrovuelo", nroVuelo));
                Parametros.Add(Paramiters.CrearParametro("@ocupacion", ocupacion));
                ConexionVuelos.ModificarVuelo(Parametros,isComun);       
            }
            catch (Exception)
            {

            }
        }



        public List<VueloPasajero> BuscarVueloPasajeros(bool isComun)
        {
            List<VueloPasajero> vuelosPasajeros = new List<VueloPasajero>();
            try
            {
                DataTable VuelosPasajeroTabla = new DataTable();
                if (isComun)
                {
                    VuelosPasajeroTabla = ConexionVuelos.BuscarVuelosPasajeros(true);
                }
                else
                {
                    VuelosPasajeroTabla = ConexionVuelos.BuscarVuelosPasajeros(false);
                }
                

                foreach (DataRow fila in VuelosPasajeroTabla.Rows)
                {
                    int nroVuelo = int.Parse(fila[0].ToString());
                    int dni = int.Parse(fila[1].ToString());
                    vuelosPasajeros.Add(new VueloPasajero(nroVuelo,dni));
                }
                return vuelosPasajeros;

            }
            catch (Exception)
            {
                return vuelosPasajeros;
            }

        }

        public string VueloPasajerosAñadir(int nroVuelo, int dni, bool isComun)
        {
            try
            {
                List<SqlParameter> Parametros = new List<SqlParameter>();
                Parametros.Add(Paramiters.CrearParametro("@nrovuelo", nroVuelo));
                Parametros.Add(Paramiters.CrearParametro("@dni", dni));

                if (ConexionVuelos.AñadirVueloPasajero(Parametros, isComun))
                {
                    return "Pasajero registrado en vuelo de forma exitosa";
                }
                
                

                return "Ocurrio algun error en la base de datos";
            }
            catch (Exception ex)
            {
                string x = ex.ToString();
                return "Ocurrio un error, intentelo mas tarde";
            }
        }


    }
}
