using FooBar.Api.ApiHandlers;
using FooBar.Api.Filters;
using FooBar.Api.Middleware;
using FluentValidation;
using FooBar.Infrastructure.DataSource;
using FooBar.Infrastructure.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Serilog;
using Serilog.Debugging;
using Serilog.Sinks.Elasticsearch;
using Prometheus;
using FooBar.Application.Querys;
using FooBar.Application.Types;
using HotChocolate.AspNetCore.Voyager;
using FooBar.Infrastructure.Adapters;
using FooBar.Infrastructure.Ports;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddValidatorsFromAssemblyContaining<Program>(ServiceLifetime.Singleton);

builder.Services.AddDbContext<DataContext>(opts =>
{
    opts.UseSqlServer(config.GetConnectionString("db"));
});

builder.Services.AddHealthChecks()
    .AddDbContextCheck<DataContext>()
    .ForwardToPrometheus();

builder.Services.AddDomainServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(Assembly.Load("FooBar.Application"), typeof(Program).Assembly);

builder.Services.AddTransient(typeof(Query));

builder.Services
            .AddGraphQLServer()
            .AddQueryType<Query>()
            .AddType<VoterType>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseHttpMetrics();

app.UseMiddleware<AppExceptionHandlerMiddleware>();

app.MapHealthChecks("/healthz", new HealthCheckOptions
{
    ResultStatusCodes =
    {
        [HealthStatus.Healthy] = StatusCodes.Status200OK,
        [HealthStatus.Degraded] = StatusCodes.Status200OK,
        [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable
    }
});

app.UseRouting().UseEndpoints(endpoint => {
    //endpoint.MapMetrics();
    endpoint.MapGraphQL();
});

app.UseVoyager(new VoyagerOptions
{
    Path = "/graphql-voyager",
    QueryPath = "/graphql"
});

app.MapGroup("/api/voter").MapVoter().AddEndpointFilterFactory(ValidationFilter.ValidationFilterFactory);

app.Run();

