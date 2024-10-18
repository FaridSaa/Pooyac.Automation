using Automation.Domain.Entity.Interface;

namespace Automation.Domain.Repository
{
    public interface IWipRepository
    {
        IWip GetById(Guid id);
        void Update(IWip wip);
        void Create(IWip wip);
        void DeleteById(Guid id);
        IEnumerable<IWip> GetAll();
    }
}
