namespace SAC.Infraestructura.Repositorios
{
    using SAC.Aplicacion.comun.Interfaces;

    public class AplicacionContexto : IAplicationContext
    {
        public IAreaRepositorio AreaRepositorio { get; set; }

        public IEmpleadoRepositorio EmpleadoRepositorio { get; set; }

        public IEstadoRepositorio EstadoRepositorio { get; set; }

        public ISedeRepositorio SedeRepositorio { get; set; }

        public ITecnicoRepositorio TecnicoRepositorio { get; set; }

        public AplicacionContexto(IAreaRepositorio areaRepositorio, IEmpleadoRepositorio empleadoRepositorio,
            IEstadoRepositorio estadoRepositorio, ISedeRepositorio sedeRepositorio, ITecnicoRepositorio tecnicoRepositorio)
        {
            AreaRepositorio = areaRepositorio;
            EmpleadoRepositorio = empleadoRepositorio;
            EstadoRepositorio = estadoRepositorio;
            SedeRepositorio = sedeRepositorio;
            TecnicoRepositorio = tecnicoRepositorio;
        }
    }
}
