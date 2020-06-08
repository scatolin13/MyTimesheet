namespace M2RG.MyTimesheet.Repositories.Interface
{
    public interface IRepositoryBase<T> where T : class 
    {
        void Inserir(T entity);
        void Inserir(params T[] entity);
        void Excluir(T entity);
        void Excluir(params T[] entity);
    }
}
