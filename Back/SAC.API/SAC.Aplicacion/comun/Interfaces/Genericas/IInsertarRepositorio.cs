namespace SAC.Aplicacion.comun.Interfaces.Genericas
{
    public interface IInsertarRepositorio<T> where T : class
    {
        Task<int> InsertarRepositorio(T entity);
    }
}
