﻿using Infow.Shared.Abstractions.Kernel.Exceptions;

namespace Infow.Shared.Abstractions.Kernel.ValueObjects;

public record FullName 
{
    public string Value { get; }
        
    public FullName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is > 100 or < 2)
        {
            throw new InvalidFullNameException(value);
        }
            
        Value = value;
    }

    public static implicit operator FullName(string value) => value is null ? null : new FullName(value);

    public static implicit operator string(FullName value) => value?.Value;
}