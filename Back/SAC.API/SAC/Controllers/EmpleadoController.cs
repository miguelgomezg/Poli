namespace SAC.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SAC.Aplicacion.Negocio.Maestras.Empleado.Consultas;
    using SAC.Aplicacion.Negocio.Maestras.Empleado.Dtos;

    /// <summary>
    /// Controlador para maestro de empleados.
    /// </summary>
    [ApiController]
    public class EmpleadoController : ApiController
    {
        /// <summary>
        /// Consulta los empleados disponibles.
        /// </summary>
        /// <returns>Lista de empleados.</returns>
        [HttpGet]
        public async Task<List<EmpleadoDto>> Get()
        {
            return await Mediator.Send(new ConsultarEmpleados());
        }


    }
}
