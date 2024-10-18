namespace Automation.Domain.Model.Incoming
{
    public record CreateWipDto
    {
        public Guid SomeNeededId { get; set; }
        public required IEnumerable<object> WorkItems { get; set; }
    }
}
