namespace SAC.Aplicacion.Negocio.Maestras.Area.Consulta
{
    using AutoMapper;
    using MediatR;
    using SAC.Aplicacion.comun.Interfaces;
    using SAC.Aplicacion.Negocio.Maestras.Area.Dto;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConsultarAreas : IRequest<List<AreaDto>>
    {
    }

    public class ConsultarAreasManejador : IRequestHandler<ConsultarAreas, List<AreaDto>>
    {
        private readonly IAplicationContext Context;

        private readonly IMapper Mapper;

        public ConsultarAreasManejador(IAplicationContext context, IMapper mapper)
        {
            Mapper = mapper;
            Context = context;
        }

        public async Task<List<AreaDto>> Handle(ConsultarAreas request, CancellationToken cancellationToken)
        {
            var data = await Context.AreaRepositorio.ObtenerTodo();
            return Mapper.Map<List<AreaDto>>(data);
        }
    }
}
