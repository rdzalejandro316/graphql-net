using FooBar.Domain.Dto;
using FooBar.Domain.Ports;
using MediatR;

namespace FooBar.Application.Voters;

public class VoterSimpleQueryHandler : IRequestHandler<VoterSimpleQuery, VoterDto>
{
    private readonly IVoterSimpleQueryRepository _repository;
    public VoterSimpleQueryHandler(IVoterSimpleQueryRepository repository) => _repository = repository;
    

    public async Task<VoterDto> Handle(VoterSimpleQuery request, CancellationToken cancellationToken)
    {
        return await _repository.Single(request.uid);                
    }
}