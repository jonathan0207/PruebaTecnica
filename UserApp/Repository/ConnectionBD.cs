
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Repository
{
    public class ConnectionBD
    {
        private readonly IConfiguration _configuracion;
        private readonly string _sql;
        public ConnectionBD(IConfiguration configuracion)
        {
            _configuracion = configuracion;
            _sql = _configuracion.GetConnectionString("ConnectionSQL");
        }

        public SqlConnection Obtener()
        {
            return new SqlConnection(_sql);
        }
    }
}
