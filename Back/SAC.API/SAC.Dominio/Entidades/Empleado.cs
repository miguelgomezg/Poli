namespace SAC.Dominio.Entidades
{
    using SAC.Dominio.Entidades.Comun;
    
    public class Empleado : EntidadBase
    {
        public string? Cargo { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Celular { get; set; }
        public string? UbicacionFisica { get; set; }
    }
}
