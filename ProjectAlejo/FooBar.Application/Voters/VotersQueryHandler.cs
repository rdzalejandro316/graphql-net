using FooBar.Domain.Dto;
using FooBar.Domain.Entities;
using FooBar.Domain.Ports;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace FooBar.Application.Voters;

public class VotersQueryHandler : IRequestHandler<VotersQuery, List<VoterDto>>
{
    private readonly IVoterRepository _repository;
    public VotersQueryHandler(IVoterRepository repository) => _repository = repository;


    public async Task<List<VoterDto>> Handle(VotersQuery request, CancellationToken cancellationToken)
    {
        var voters = await _repository.GetVoters();
        List<VoterDto> voterDtos = new List<VoterDto>();
        foreach (Voter item in voters)
        {
            var voter = new VoterDto(item.Id, item.Nid, item.DateOfBirth, item.Origin);
            voterDtos.Add(voter);
        }

        return voterDtos;
    }
}