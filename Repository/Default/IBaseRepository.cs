using System.Linq;

namespace Repository
{
    public interface IBaseRepository<T> where T : class
    {
        string Incluir(T entity);
        string Alterar(T entity);
        string Excluir(T entity);
        T Selecionar(int id);
        IQueryable<T> SelecionarTodos();
    }
}
