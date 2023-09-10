using Infow.Shared.Abstractions.Exceptions;

namespace Infow.Shared.Abstractions.Kernel.Exceptions;

public class UnsupportedNationalityException : InflowException
{
    public string Nationality { get; }

    public UnsupportedNationalityException(string nationality) : base($"Nationality: '{nationality}' is unsupported.")
    {
        Nationality = nationality;
    }
}