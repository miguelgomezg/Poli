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

    public class EstadoRepositorio : IEstadoRepositorio
    {
        private readonly IConfiguration Configuracion;

        public EstadoRepositorio(IConfiguration configuration)
        {
            Configuracion = configuration;
        }


        public Task<int> InsertarRepositorio(Estado entity)
        {
            throw new NotImplementedException();
        }

        public Task<Estado> Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Estado>> ObtenerTodo()
        {
            using var connection = ConexionFactoria.Conexion(Configuracion);

            IEnumerable<Estado> estados;

            var result = await connection.QueryAsync<EstadoModelo>(
                "sp_ConsultarEstados",
                commandType: CommandType.StoredProcedure);

            estados = from estado in result.ToList()
                      select new Estado
                      {
                          Codigo = estado.Codigo_Estado,
                          Nombre = estado.Nombre_Estado,
                      };

            return estados;
        }
    }
}
