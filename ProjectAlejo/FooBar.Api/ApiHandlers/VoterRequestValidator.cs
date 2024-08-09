using FooBar.Application.Voters;
using FluentValidation;

namespace FooBar.Api.ApiHandlers;

public class VoterRequestValidator : AbstractValidator<VoterRegisterCommand>
{
    const int MIN_LENGTH = 8;
    public VoterRequestValidator()
    {
        RuleFor(x => x.Nid).NotEmpty().MinimumLength(MIN_LENGTH);
        RuleFor(x => x.Dob).NotEmpty();
        RuleFor(x => x.Origin).NotEmpty();
    }
}