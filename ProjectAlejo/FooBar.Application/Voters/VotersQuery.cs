using FooBar.Domain.Dto;
using MediatR;

namespace FooBar.Application.Voters;

public record VotersQuery() : IRequest<List<VoterDto>>;