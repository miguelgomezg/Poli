namespace SAC.Aplicacion.Negocio.Maestras.Area.Mapeos
{
    using AutoMapper;
    using SAC.Aplicacion.Negocio.Maestras.Area.Dto;
    using SAC.Dominio.Entidades;

    public class AreaPerfilMapeo : Profile
    {
        public AreaPerfilMapeo()
        {
            CreateMap<Area, AreaDto>();
        }
    }
}
