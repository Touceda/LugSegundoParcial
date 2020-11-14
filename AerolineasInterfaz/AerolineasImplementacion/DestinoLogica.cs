using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineasObjetos;
using System.Data;
using AccesoSQL;
using System.Data.SqlClient;

namespace AerolineasImplementacion
{
    public class DestinoLogica
    {
        AccesoDestinos ConexionDestinos = new AccesoDestinos();
        Parametros Paramiters = new Parametros();

        public List<Destino> DestinosLeer()
        {
            List<Destino> Destinos = new List<Destino>();
            try
            {
                DataTable PasajerosTabla = ConexionDestinos.BuscarDestinos();
                
                foreach (DataRow fila in PasajerosTabla.Rows)
                {
                    int id = int.Parse(fila[0].ToString());
                    string destino = fila[1].ToString();
                    string ubicacion = fila[2].ToString();
                    Destinos.Add(new Destino(destino, ubicacion, id));
                }
                return Destinos;
            }
            catch (Exception)
            {
                return Destinos;
            }
        }
        public string DestinoAñadir(Destino Destino)
        {
            try
            {
                DataTable DestinosTabla = ConexionDestinos.BuscarDestinos();

    

                List<SqlParameter> Parametros = new List<SqlParameter>();
                Parametros.Add(Paramiters.CrearParametro("@destino", Destino.LugarDestino));
                Parametros.Add(Paramiters.CrearParametro("@ubicacion", Destino.DestinoMaps));
                if (ConexionDestinos.AñadirDestino(Parametros))
                {
                    return "Destino Creado Exitosamente";
                }
                return "Ocurrio un error en la base de datos";
            }
            catch (Exception)
            {
                return "Ocurrio un error, intentelo mas tarde";
            }
        }
        public string DestinoModificar(Destino Destino)
        {
            try
            {
                List<SqlParameter> Parametros = new List<SqlParameter>();
                Parametros.Add(Paramiters.CrearParametro("@id", Destino.Id));
                Parametros.Add(Paramiters.CrearParametro("@destino", Destino.LugarDestino));
                Parametros.Add(Paramiters.CrearParametro("@ubicacion", Destino.DestinoMaps));
                ConexionDestinos.ModificarDestino(Parametros);
                return "Modificacion realizada con exito";
            }
            catch (Exception)
            {
                return "Ocurrio un error, Intentelo mas tarde";
            }
        }
        public bool DestinoBorrar(int id)
        {
            try
            {
                ConexionDestinos.BorrarDestino(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
