using Automation.Domain.Model.Incoming;

namespace Automation.Domain.Service.Interface
{
    public interface IWipService
    {
        void Submit(CreateWipDto model);
        void Cancel(Guid Id);
    }
}
