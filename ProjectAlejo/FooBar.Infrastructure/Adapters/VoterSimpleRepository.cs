﻿using Dapper;
using FooBar.Domain.Dto;
using FooBar.Domain.Ports;
using FooBar.Infrastructure.DataSource;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace FooBar.Infrastructure.Adapters;


[Repository]
public class VoterSimpleRepository : IVoterSimpleQueryRepository
{
    private readonly IDbConnection _dbConn;
    public VoterSimpleRepository(DataContext dc) =>  _dbConn = dc.Database.GetDbConnection();
            
    
    public async Task<VoterDto> Single(Guid id)
    {
        var res = await _dbConn
            .QuerySingleOrDefaultAsync<VoterDto>(@"select id , dateOfBirth, origin from Voter where Id = @Id",
                new { Id = id }
                );
        return res;
    }
}

