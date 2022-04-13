namespace SAC.Aplicacion.Negocio.Maestras.Empleado.Consultas
{
    using AutoMapper;
    using MediatR;
    using SAC.Aplicacion.comun.Interfaces;
    using SAC.Aplicacion.Negocio.Maestras.Empleado.Dtos;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ConsultarEmpleados : IRequest<List<EmpleadoDto>>
    {
    }

    public class ConsultarEmpleadoManejador : IRequestHandler<ConsultarEmpleados, List<EmpleadoDto>>
    {
        private readonly IMapper Mapper;
        private readonly IAplicationContext Contexto;

        public ConsultarEmpleadoManejador(IMapper mapper, IAplicationContext context)
        {
            Mapper = mapper;
            Contexto = context;
        }


        public async Task<List<EmpleadoDto>> Handle(ConsultarEmpleados request, CancellationToken cancellationToken)
        {
            var data = await Contexto.EmpleadoRepositorio.ObtenerTodo();
            return Mapper.Map<List<EmpleadoDto>>(data);
        }
    }
}
