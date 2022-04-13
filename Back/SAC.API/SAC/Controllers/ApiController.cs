namespace SAC.API.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controlador base.
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private IMediator? _mediator;

        /// <summary>
        /// 
        /// </summary>
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
