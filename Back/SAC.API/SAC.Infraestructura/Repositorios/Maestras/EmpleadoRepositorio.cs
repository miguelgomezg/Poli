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

    public class EmpleadoRepositorio : IEmpleadoRepositorio
    {
        private readonly IConfiguration Configuracion;

        public EmpleadoRepositorio(IConfiguration configuration)
        {
            Configuracion = configuration;
        }

        public Task<int> InsertarRepositorio(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> Obtener(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Empleado>> ObtenerTodo()
        {
            using var connection = ConexionFactoria.Conexion(Configuracion);

            IEnumerable<Empleado> empleados;

            var result = await connection.QueryAsync<EmpleadoModelo>(
                "sp_ConsultarEmpleados",
                commandType: CommandType.StoredProcedure);

            empleados = from empleado in result.ToList()
                    select new Empleado
                    {
                        Codigo = empleado.Codigo_Empleado,
                        Cargo =  empleado.Cargo_Empleado,
                        Email = empleado.EMail_Empleado,
                        Telefono = empleado.Telefono_Empleado,
                        Celular = empleado.Celular_Empleado,
                        UbicacionFisica = empleado.Ubicacion_Fisica_Empleado

                    };

            return empleados;
        }
    }
}
