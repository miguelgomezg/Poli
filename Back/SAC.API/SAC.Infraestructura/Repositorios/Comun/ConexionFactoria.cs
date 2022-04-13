namespace SAC.Infraestructura.Repositorios.Comun
{
    using Microsoft.Extensions.Configuration;
    using System.Data.SqlClient;

    public class ConexionFactoria
    {
        public static SqlConnection Conexion(IConfiguration configuracion)
        {
            string cadena = configuracion.GetConnectionString("SAC");
            return new SqlConnection(cadena);
        }
    }
}
