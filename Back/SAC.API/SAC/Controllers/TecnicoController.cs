namespace SAC.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SAC.Aplicacion.Negocio.Maestras.Tecnico.Consultas;
    using SAC.Aplicacion.Negocio.Maestras.Tecnico.Dtos;

    /// <summary>
    /// Controlador para maestro de tecnicos.
    /// </summary>
    [ApiController]
    public class TecnicoController : ApiController
    {
        /// <summary>
        /// Consulta todos los tecnicos disponibles.
        /// </summary>
        /// <returns>Listado de tecnicos</returns>
        [HttpGet]
        public async Task<List<TecnicoDto>> Get()
        {
            return await Mediator.Send(new ConsultarTecnicos());
        }
    }
}
