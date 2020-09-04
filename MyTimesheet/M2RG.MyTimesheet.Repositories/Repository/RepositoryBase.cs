using M2RG.MyTimesheet.Repositories.Context;
using M2RG.MyTimesheet.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace M2RG.MyTimesheet.Repositories.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly TimesheetContext context;
        private readonly DbContextOptions<TimesheetContext> optionsBuilder;

        public RepositoryBase()
        {
            context = new TimesheetContext(optionsBuilder);
        }

        public void Inserir(T entity)
        {
            context.Add(entity);
        }

        public void Inserir(params T[] entities)
        {
            context.AddRange(entities);
        }

        public void Atualizar(T entity)
        {
            context.Update(entity);
        }

        public void Atualizar(params T[] entities)
        {
            context.Update(entities);
        }

        public void Excluir(T entity)
        {
            context.Remove(entity);
        }

        public void Excluir(params T[] entities)
        {
            context.RemoveRange(entities);
        }
    }
}
