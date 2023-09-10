using Infow.Shared.Abstractions.Exceptions;

namespace Infow.Shared.Abstractions.Kernel.Exceptions;

public class InvalidFullNameException : InflowException
{
    public string FullName { get; }

    public InvalidFullNameException(string fullName) : base($"Full name: '{fullName}' is invalid.")
    {
        FullName = fullName;
    }
}