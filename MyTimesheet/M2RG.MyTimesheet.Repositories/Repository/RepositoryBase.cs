using M2RG.MyTimesheet.Repositories.Context;
using M2RG.MyTimesheet.Repositories.Interface;

namespace M2RG.MyTimesheet.Repositories.Repository
{
    public abstract class RepositoryBase<T> where T : class, IRepositoryBase<T> 
    {
        private readonly TimesheetContext context;
        public RepositoryBase(TimesheetContext context)
        {
            this.context = context;
        }

        public void Inserir(T entity)
        {
            context.Add(T);
        }

        public void Inserir(params T[] entity)
        {
            context.AddRange(T);
        }

        public void Excluir(T entity)
        {

        }

        public void Excluir(params T[] entity)
        {

        }
    }
}
