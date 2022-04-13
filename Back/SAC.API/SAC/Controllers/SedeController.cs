namespace SAC.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SAC.Aplicacion.Negocio.Maestras.Sede.Consultas;
    using SAC.Aplicacion.Negocio.Maestras.Sede.Dtos;

    /// <summary>
    /// Controlador para maestro de sedes.
    /// </summary>
    [ApiController]
    public class SedeController : ApiController
    {
        /// <summary>
        /// Consulta todas la sedes disponibles.
        /// </summary>
        /// <returns>Listado de sedes.</returns>
        [HttpGet]
        public async Task<List<SedeDto>> Get()
        {
            return await Mediator.Send(new ConsultarSedes());
        }
    }
}
