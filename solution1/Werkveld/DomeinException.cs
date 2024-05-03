using System.Runtime.Serialization;

namespace Werkveld
{
    [Serializable]
    internal class DomeinException : Exception
    {
        public DomeinException()
        {
        }

        public DomeinException(string? message) : base(message)
        {
        }

        public DomeinException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DomeinException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}