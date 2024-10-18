using Automation.Domain.Entity.Enum;

namespace Automation.Domain.Entity.Interface
{
    public interface IWip
    {
        public Guid Id { get; set; }
        public Guid FlowId { get; set; }
        public WipState State { get; set; }
    }
}
