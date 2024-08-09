using FooBar.Domain.Dto;

namespace FooBar.Domain.Ports
{
    public interface IVoterSimpleQueryRepository
    {
        Task<VoterDto> Single(Guid id);
    }
}

