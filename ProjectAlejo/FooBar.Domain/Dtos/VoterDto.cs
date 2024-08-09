namespace FooBar.Domain.Dto;

public record VoterDto(Guid Id, string Nid, DateTime dateOfBirth, string origin);