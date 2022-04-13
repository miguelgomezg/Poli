namespace SAC.Aplicacion.Negocio.Maestras.Tecnico.Mapeos
{
    using AutoMapper;
    using SAC.Aplicacion.Negocio.Maestras.Tecnico.Dtos;
    using SAC.Dominio.Entidades;

    public class TecnicoPerfilMapeo : Profile
    {
        public TecnicoPerfilMapeo()
        {
            CreateMap<Tecnico, TecnicoDto>();
        }
    }
}
