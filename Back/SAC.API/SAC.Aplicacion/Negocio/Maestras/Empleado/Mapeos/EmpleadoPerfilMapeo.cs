namespace SAC.Aplicacion.Negocio.Maestras.Empleado.Mapeos
{
    using AutoMapper;
    using SAC.Aplicacion.Negocio.Maestras.Empleado.Dtos;
    using SAC.Dominio.Entidades;

    public class EmpleadoPerfilMapeo : Profile
    {
        public EmpleadoPerfilMapeo()
        {
            CreateMap<Empleado, EmpleadoDto>();
        }
    }
}
