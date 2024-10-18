using Automation.Domain.Entity.Enum;
using Automation.Domain.Entity.Interface;

namespace Automation.Domain.Entity
{
    public class Wip : IWip
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid FlowId { get; set; }
        public WipState State { get; set; }
    }
}
