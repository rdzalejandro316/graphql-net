using System.Runtime.Serialization;

namespace FooBar.Domain.Exceptions;

[Serializable]
public sealed class UnderAgeException : CoreBusinessException
{
    public UnderAgeException()
    {        
    }
    
    public UnderAgeException(string msg) : base(msg)
    {
    }

    public UnderAgeException(string message, Exception inner) : base(message, inner)
    {
    }

    private  UnderAgeException(SerializationInfo info, StreamingContext context) 
    : base(info, context) 
    {        
    }

}