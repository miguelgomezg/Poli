namespace SAC.Aplicacion.comun.Interfaces.Genericas
{
    public interface IObtenerRepositoio<T> where T : class
    {
        Task<T> Obtener(int Id);
    }
}
