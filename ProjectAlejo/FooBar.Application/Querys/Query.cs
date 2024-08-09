using FooBar.Domain.Dto;
using FooBar.Domain.Entities;
using FooBar.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar.Application.Querys;

public class Query
{
    private readonly IVoterRepository _repository;
    public Query(IVoterRepository repository) => _repository = repository;

    public async Task<List<VoterDto>> GetVoters()
    {
        var voters = await _repository.GetVoters();
        List<VoterDto> voterDtos = new List<VoterDto>();
        //List<VoterDto> voterDtos = new List<VoterDto>() {
        //    new VoterDto(Guid.NewGuid(), new DateTime(), "PERU")
        //};
        foreach (Voter item in voters)
        {
            var voter = new VoterDto(item.Id, item.Nid, item.DateOfBirth, item.Origin);
            voterDtos.Add(voter);
        }

        return voterDtos;
    }

}
