using Automation.Domain.Model.Incoming;
using FluentValidation;

namespace Automation.Application.Validation
{
    public class CreateWipDtoValidation :  AbstractValidator<CreateWipDto>
    {
        public CreateWipDtoValidation()
        {
            this.RuleFor(m => m.WorkItems).NotEmpty();
        }
    }
}
