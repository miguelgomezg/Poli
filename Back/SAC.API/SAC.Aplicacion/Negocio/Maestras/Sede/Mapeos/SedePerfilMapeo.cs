namespace SAC.Aplicacion.Negocio.Maestras.Sede.Mapeos
{
    using AutoMapper;
    using SAC.Aplicacion.Negocio.Maestras.Sede.Dtos;
    using SAC.Dominio.Entidades;

    public class SedePerfilMapeo : Profile
    {
        public SedePerfilMapeo()
        {
            CreateMap<Sede, SedeDto>();
        }
    }
}
