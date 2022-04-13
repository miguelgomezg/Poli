namespace SAC.Dominio.Entidades
{
    using SAC.Dominio.Entidades.Comun;

    public class Tecnico : EntidadBase
    {
        public string? Cargo { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
    }
}
