using System.Runtime.Serialization;

namespace Fiorella.Persistence.Implementations.Services
{
    [Serializable]
    internal class DublicatedException : Exception
    {
        public DublicatedException()
        {
        }

        public DublicatedException(string? message) : base(message)
        {
        }

        public DublicatedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DublicatedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}