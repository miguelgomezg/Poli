namespace SAC.Aplicacion.Negocio.Maestras.Estados.Consultas
{
    using AutoMapper;
    using MediatR;
    using SAC.Aplicacion.comun.Interfaces;
    using SAC.Aplicacion.Negocio.Maestras.Estados.Dto;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConsultarEstados : IRequest<List<EstadoDto>>
    {
    }

    public class ConsultarEstadosManejador : IRequestHandler<ConsultarEstados, List<EstadoDto>>
    {
        private readonly IMapper Maper;
        private readonly IAplicationContext Contexto;

        public ConsultarEstadosManejador(IMapper mapper, IAplicationContext context)
        {
            Maper = mapper;
            Contexto = context;
        }


        public async Task<List<EstadoDto>> Handle(ConsultarEstados request, CancellationToken cancellationToken)
        {
            var data = await Contexto.EstadoRepositorio.ObtenerTodo();
            return Maper.Map<List<EstadoDto>>(data);
        }
    }
}
