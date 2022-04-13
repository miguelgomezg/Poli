namespace SAC.Aplicacion.Negocio.Maestras.Tecnico.Consultas
{
    using AutoMapper;
    using MediatR;
    using SAC.Aplicacion.comun.Interfaces;
    using SAC.Aplicacion.Negocio.Maestras.Tecnico.Dtos;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConsultarTecnicos : IRequest<List<TecnicoDto>>
    {
    }

    public class ConsultarTecnicosManejador : IRequestHandler<ConsultarTecnicos, List<TecnicoDto>>
    {
        private readonly IMapper Mapper;
        private readonly IAplicationContext Contexto;

        public ConsultarTecnicosManejador(IMapper mapper, IAplicationContext context)
        {
            Mapper = mapper;
            Contexto = context;
        }


        public async Task<List<TecnicoDto>> Handle(ConsultarTecnicos request, CancellationToken cancellationToken)
        {
            var data = await Contexto.TecnicoRepositorio.ObtenerTodo();
            return Mapper.Map<List<TecnicoDto>>(data);
        }
    }
}
