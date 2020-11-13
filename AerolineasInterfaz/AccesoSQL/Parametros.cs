using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoSQL
{
    public class Parametros
    {
        public SqlParameter CrearParametro(string tipo, string valor)
        {
            SqlParameter parametro = new SqlParameter(tipo, valor);
            parametro.SqlDbType = System.Data.SqlDbType.Text;
            return parametro;
        }
        public SqlParameter CrearParametro(string tipo, int valor)
        {
            SqlParameter parametro = new SqlParameter(tipo, valor);
            parametro.SqlDbType = System.Data.SqlDbType.Int;
            return parametro;
        }
    }
}
