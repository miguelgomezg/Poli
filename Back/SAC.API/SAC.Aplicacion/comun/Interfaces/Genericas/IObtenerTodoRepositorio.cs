namespace SAC.Aplicacion.comun.Interfaces.Genericas
{
    public interface IObtenerTodoRepositorio<T> where T : class
    {
        Task<IEnumerable<T>> ObtenerTodo();
    }
}
