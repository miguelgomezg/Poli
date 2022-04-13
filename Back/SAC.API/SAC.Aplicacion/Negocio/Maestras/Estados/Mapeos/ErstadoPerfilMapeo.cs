namespace SAC.Aplicacion.Negocio.Maestras.Estados.Mapeos
{
    using AutoMapper;
    using SAC.Aplicacion.Negocio.Maestras.Estados.Dto;
    using SAC.Dominio.Entidades;

    public class ErstadoPerfilMapeo : Profile
    {
        public ErstadoPerfilMapeo()
        {
            CreateMap<Estado, EstadoDto>();
        }
    }
}
