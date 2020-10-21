using System;
using System.Runtime.Serialization;

namespace CAToDo.Core.Exceptions
{
    public class ToDoItemNotFoundException : Exception
    {
        public ToDoItemNotFoundException()
        {
        }

        public ToDoItemNotFoundException(string message) : base(message)
        {
        }

        public ToDoItemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ToDoItemNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
