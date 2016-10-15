using System.Collections.Generic;
using Ocelot.Library.Infrastructure.Errors;

namespace Ocelot.Library.Infrastructure.Responses
{
    public abstract class Response<T> : Response
    {
        protected Response(T data)
        {
            Data = data;
        }

        protected Response(List<Error> errors) : base(errors)
        {
        }

        public T Data { get; private set; }
        
    }
} 