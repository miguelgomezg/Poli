namespace SAC.Infraestructura.Repositorios.Maestras
{
    using Dapper;
    using Microsoft.Extensions.Configuration;
    using SAC.Aplicacion.comun.Interfaces;
    using SAC.Dominio.Entidades;
    using SAC.Infraestructura.Repositorios.Comun;
    using SAC.Infraestructura.Repositorios.Modelos;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public class SedeRepositorio : ISedeRepositorio
    {
        public readonly IConfiguration Configuracion;

        public SedeRepositorio(IConfiguration configuracion)
        {
            Configuracion = configuracion;
        }


        public Task<int> InsertarRepositorio(Sede entity)
        {
            throw new NotImplementedException();
        }

        public Task<Sede> Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Sede>> ObtenerTodo()
        {
            using var connection = ConexionFactoria.Conexion(Configuracion);

            IEnumerable<Sede> sedes;

            var result = await connection.QueryAsync<SedeModelo>(
                "sp_ConsultarSedes",
                commandType: CommandType.StoredProcedure);

            sedes = from estado in result.ToList()
                    select new Sede
                    {
                        Codigo = estado.Codigo_Sede,
                        Nombre = estado.Nombre_Sede,
                    };

            return sedes;
        }
    }
}
