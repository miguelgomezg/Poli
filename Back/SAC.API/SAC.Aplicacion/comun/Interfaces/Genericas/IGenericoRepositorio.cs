namespace SAC.Aplicacion.comun.Interfaces.Genericas
{
    public interface IGenericoRepositorio<T> : IObtenerRepositoio<T>, IObtenerTodoRepositorio<T>, IInsertarRepositorio<T> where T : class
    {
    }
}
