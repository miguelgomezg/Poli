namespace SAC.Aplicacion.Negocio.Maestras.Sede.Consultas
{
    using AutoMapper;
    using MediatR;
    using SAC.Aplicacion.comun.Interfaces;
    using SAC.Aplicacion.Negocio.Maestras.Sede.Dtos;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConsultarSedes : IRequest<List<SedeDto>>
    {
    }

    public class ConsultarSedesManejador : IRequestHandler<ConsultarSedes, List<SedeDto>>
    {
        private readonly IMapper Mapper;
        private readonly IAplicationContext Contexto;

        public ConsultarSedesManejador(IMapper mapper, IAplicationContext context)
        {
            Mapper = mapper;
            Contexto = context;
        }

        public async Task<List<SedeDto>> Handle(ConsultarSedes request, CancellationToken cancellationToken)
        {
            var data = await Contexto.SedeRepositorio.ObtenerTodo();
            return Mapper.Map<List<SedeDto>>(data);
        }
    }
}
