using FooBar.Domain.Dto;
using MediatR;


namespace FooBar.Application.Voters;

public record VoterRegisterCommand(
    string Nid, string Origin, DateTime Dob
    ) : IRequest<VoterDto>;

