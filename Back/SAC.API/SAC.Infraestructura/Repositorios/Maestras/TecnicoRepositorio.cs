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

    public class TecnicoRepositorio : ITecnicoRepositorio
    {
        public readonly IConfiguration Configuracion;

        public TecnicoRepositorio(IConfiguration configuracion)
        {
            Configuracion = configuracion;
        }


        public Task<int> InsertarRepositorio(Tecnico entity)
        {
            throw new NotImplementedException();
        }

        public Task<Tecnico> Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tecnico>> ObtenerTodo()
        {
            using var connection = ConexionFactoria.Conexion(Configuracion);

            IEnumerable<Tecnico> tecnicos;

            var result = await connection.QueryAsync<TecnicoModelo>(
                "sp_ConsultarTecnicos",
                commandType: CommandType.StoredProcedure);

            tecnicos = from tecnico in result.ToList()
                       select new Tecnico
                       {
                           Codigo = tecnico.Codigo_Tecnico,
                           Nombre = tecnico.Nombre_Tecnico,
                           Cargo = tecnico.Cargo_Tecnico,
                           Email = tecnico.EMail_Tecnico,
                           Celular = tecnico.Celular_Tecnico

                       };

            return tecnicos;
        }
    }
}
