using System.Runtime.Serialization;

namespace Fiorella.Persistence.Inplementations.Services
{
    [Serializable]
    internal class UserRegistrationException : Exception
    {
        public UserRegistrationException()
        {
        }

        public UserRegistrationException(string? message) : base(message)
        {
        }

        public UserRegistrationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserRegistrationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}