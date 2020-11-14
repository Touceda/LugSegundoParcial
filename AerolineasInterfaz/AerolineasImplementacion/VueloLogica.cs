using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineasObjetos;
using AccesoSQL;
using System.Data;

namespace AerolineasImplementacion
{
    public class VueloLogica
    {

        AccesoVuelos ConexionVuelos = new AccesoVuelos();
        Parametros Paramiters = new Parametros();

        public List<Vuelo> DestinosLeer(bool isComun)
        {

            List<Vuelo> Vuelos = new List<Vuelo>();
            List<Vuelo> VuelosInternacionales = new List<Vuelo>();
            try
            {
                if (isComun)
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
                        Vuelos.Add(new Vuelo(nroVuelo,destino,partida,llegada,asientos,ocupacion));
                    }
                    return Vuelos;
                }
                else
                {
                    return VuelosInternacionales;
                }
            }        
            catch (Exception)
            {
                if (isComun)
                {
                    return Vuelos;
                }
                else
                {
                    return VuelosInternacionales;
                }
                
            }
        }

        //public string DestinoAñadir(Destino Destino)
        //{
        //    try
        //    {
        //        DataTable DestinosTabla = ConexionDestinos.BuscarDestinos();



        //        List<SqlParameter> Parametros = new List<SqlParameter>();
        //        Parametros.Add(Paramiters.CrearParametro("@destino", Destino.LugarDestino));
        //        Parametros.Add(Paramiters.CrearParametro("@ubicacion", Destino.DestinoMaps));
        //        if (ConexionDestinos.AñadirDestino(Parametros))
        //        {
        //            return "Destino Creado Exitosamente";
        //        }
        //        return "Ocurrio un error en la base de datos";
        //    }
        //    catch (Exception)
        //    {
        //        return "Ocurrio un error, intentelo mas tarde";
        //    }
        //}
        //public string DestinoModificar(Destino Destino)
        //{
        //    try
        //    {
        //        List<SqlParameter> Parametros = new List<SqlParameter>();
        //        Parametros.Add(Paramiters.CrearParametro("@id", Destino.Id));
        //        Parametros.Add(Paramiters.CrearParametro("@destino", Destino.LugarDestino));
        //        Parametros.Add(Paramiters.CrearParametro("@ubicacion", Destino.DestinoMaps));
        //        ConexionDestinos.ModificarDestino(Parametros);
        //        return "Modificacion realizada con exito";
        //    }
        //    catch (Exception)
        //    {
        //        return "Ocurrio un error, Intentelo mas tarde";
        //    }
        //}
        //public bool DestinoBorrar(int id)
        //{
        //    try
        //    {
        //        ConexionDestinos.BorrarDestino(id);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}



    }
}
