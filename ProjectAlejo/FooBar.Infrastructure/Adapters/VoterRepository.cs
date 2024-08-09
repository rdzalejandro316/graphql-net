using FooBar.Domain.Entities;
using FooBar.Domain.Ports;
using FooBar.Infrastructure.Ports;

namespace FooBar.Infrastructure.Adapters
{
    [Repository]
    public class VoterRepository : IVoterRepository
    {
        readonly IRepository<Voter> _dataSource;
        public VoterRepository(IRepository<Voter> dataSource) => _dataSource = dataSource 
            ?? throw new ArgumentNullException(nameof(dataSource));

        public async Task<IEnumerable<Voter>> GetVoters()
        {
            var voters = await _dataSource.GetManyAsync();
            return voters;
        }

        public async Task<Voter> SaveVoter(Voter v) => await _dataSource.AddAsync(v);

        public async Task<Voter> SingleVoter(Guid uid) => await _dataSource.GetOneAsync(uid);
        
        
    }
}
