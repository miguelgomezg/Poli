namespace SAC.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SAC.Aplicacion.Negocio.Maestras.Area.Consulta;
    using SAC.Aplicacion.Negocio.Maestras.Area.Dto;

    /// <summary>
    /// Controlador para el maestro de areas.
    /// </summary>
    [ApiController]
    public class AreaController : ApiController
    {
        /// <summary>
        /// Consulta todas las areas disponibles.
        /// </summary>
        /// <returns>Listado de areas.</returns>
        [HttpGet]
        public async Task<List<AreaDto>> Get()
        {
            return await Mediator.Send(new ConsultarAreas());
        }
    }
}
