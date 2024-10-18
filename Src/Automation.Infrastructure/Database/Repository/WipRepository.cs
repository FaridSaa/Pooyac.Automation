using Automation.Domain.Entity.Interface;
using Automation.Domain.Repository;
using Automation.Infrastructure.Database.Context;

namespace Automation.Infrastructure.Database.Repository
{
    public class WipRepository(AppDbContext appDbContext) : IWipRepository
    {
        private readonly AppDbContext appDbContext = appDbContext;

        public void Create(IWip wip)
        {
            _ = appDbContext.Wip.AddAsync(wip);
            appDbContext.SaveChanges();
        }

        public IEnumerable<IWip> GetAll() => appDbContext.Wip.AsEnumerable();

        public IWip GetById(Guid id) => appDbContext.Wip.First(x => x.Id == id);

        public void Update(IWip wip)
        {
            throw new NotImplementedException();
        }
        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
