namespace M2RG.MyTimesheet.Repositories.Interface
{
    public interface IRepositoryBase<T> where T : class 
    {
        void Inserir(T entity);
        void Inserir(params T[] entities);
        void Atualizar(T entity);
        void Atualizar(params T[] entities);
        void Excluir(T entity);
        void Excluir(params T[] entities);
    }
}
