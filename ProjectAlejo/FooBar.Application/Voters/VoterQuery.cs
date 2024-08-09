using FooBar.Domain.Dto;
using MediatR;

namespace FooBar.Application.Voters;

public record VoterQuery(
    Guid uid
    ) : IRequest<VoterDto>;

public record VoterSimpleQuery(
    Guid uid
    ) : IRequest<VoterDto>;
