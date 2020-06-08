using M2RG.MyTimesheet.Domain.Models;
using M2RG.MyTimesheet.DTO;

namespace M2RG.MyTimesheet.Repositories.Interface
{
    public interface IAgendaRepository : IRepositoryBase<Escalas>
    {
        AgendasDTO ConsultarPorId(int id);
        
    }
}
