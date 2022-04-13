namespace SAC.Infraestructura
{
    using Microsoft.Extensions.DependencyInjection;
    using SAC.Aplicacion.comun.Interfaces;
    using SAC.Infraestructura.Repositorios;
    using SAC.Infraestructura.Repositorios.Maestras;

    public static class InyeccionDependencias
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection servicios)
        {
            servicios.AddTransient<IAreaRepositorio, AreaRepositorio>();
            servicios.AddTransient<IAplicationContext, AplicacionContexto>();
            servicios.AddTransient<IEmpleadoRepositorio, EmpleadoRepositorio>();
            servicios.AddTransient<IEstadoRepositorio, EstadoRepositorio>();
            servicios.AddTransient<ISedeRepositorio, SedeRepositorio>();
            servicios.AddTransient<ITecnicoRepositorio, TecnicoRepositorio>();

            return servicios;
        }
    }
}
