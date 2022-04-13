namespace SAC.Aplicacion.comun.Interfaces
{
    public interface IAplicationContext
    {
        public IAreaRepositorio AreaRepositorio { set; get; }

        public IEmpleadoRepositorio EmpleadoRepositorio { set; get; }

        public IEstadoRepositorio EstadoRepositorio { get; set; }

        public ISedeRepositorio SedeRepositorio { set; get; }

        public ITecnicoRepositorio TecnicoRepositorio { set; get; }
    }
}
