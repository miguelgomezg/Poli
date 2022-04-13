
namespace SAC.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SAC.Aplicacion.Negocio.Maestras.Estados.Consultas;
    using SAC.Aplicacion.Negocio.Maestras.Estados.Dto;

    /// <summary>
    /// Controlador para el maestro de estados.
    /// </summary>
    [ApiController]
    public class EstadoController : ApiController
    {
        /// <summary>
        /// Consulta todos los estados disponibles.
        /// </summary>
        /// <returns>Listado de estados.</returns>
        [HttpGet]
        public async Task<List<EstadoDto>> Get()
        {
            return await Mediator.Send(new ConsultarEstados());
        }
    }
}
