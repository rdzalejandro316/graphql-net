using FooBar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar.Application.Types;

public class VoterType: ObjectType<Voter>
{
    protected override void Configure(IObjectTypeDescriptor<Voter> descriptor)
    {
        descriptor.Field(u => u.Id).Type<NonNullType<IdType>>();
        descriptor.Field(u => u.Nid).Type<NonNullType<StringType>>();
        descriptor.Field(u => u.Origin).Type<NonNullType<StringType>>();
        descriptor.Field(u => u.DateOfBirth).Type<StringType>();
    }

}
