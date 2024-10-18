using Automation.Domain.Entity;
using Automation.Domain.Entity.Enum;
using Automation.Domain.Model.Incoming;
using Automation.Domain.Repository;
using Automation.Domain.Service.Interface;

namespace Automation.Domain.Service
{
    public sealed class WipService(IWipRepository repository) : IWipService
    {
        private readonly IWipRepository repository = repository;
        public void Submit(CreateWipDto model)
        {
            var wip = new Wip()
            {
                FlowId = model.SomeNeededId,
                State = WipState.Created
            };
            repository.Create(wip);
        }
        public void Cancel(Guid Id)
        {
            var wip = repository.GetById(Id);
            wip.State = WipState.Canceled;
            repository.Update(wip);
        }
    }
}
