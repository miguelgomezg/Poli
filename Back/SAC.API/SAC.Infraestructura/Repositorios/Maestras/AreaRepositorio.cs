namespace SAC.Infraestructura.Repositorios.Maestras
{
    using Dapper;
    using Microsoft.Extensions.Configuration;
    using SAC.Aplicacion.comun.Interfaces;
    using SAC.Dominio.Entidades;
    using SAC.Infraestructura.Repositorios.Comun;
    using SAC.Infraestructura.Repositorios.Modelos;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    public class AreaRepositorio : IAreaRepositorio
    {
        private readonly IConfiguration Configuracion;

        public AreaRepositorio(IConfiguration configuration)
        {
            Configuracion = configuration;
        }

        public Task<int> InsertarRepositorio(Area entity)
        {
            throw new NotImplementedException();
        }

        public Task<Area> Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Area>> ObtenerTodo()
        {
            using var connection = ConexionFactoria.Conexion(Configuracion);

            IEnumerable<Area> areas;

            var result = await connection.QueryAsync<AreaModelo>(
                "sp_ConsultarAreas",
                commandType: CommandType.StoredProcedure);

            areas = from area in result.ToList()
                    select new Area
                    {
                        Codigo = area.Codigo_Area,
                        Nombre = area.Nombre_Area
                    };

            return areas;
        }
    }
}
