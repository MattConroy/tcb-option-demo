using System;

namespace TCB.Option.Demo.Infrastructure
{
    internal sealed class MissingStringException : Exception
    {
        public int StringId { get; }

        public MissingStringException(in int stringId) : base($"Failed to load string for ID: {stringId}")
        {
            StringId = stringId;
        }
    }
}