using FooBar.Domain.Entities;

namespace FooBar.Domain.Ports
{
    public interface IVoterRepository
    {
        Task<Voter> SaveVoter(Voter v);
        Task<Voter> SingleVoter(Guid uid);
        Task<IEnumerable<Voter>> GetVoters();
    }
}

