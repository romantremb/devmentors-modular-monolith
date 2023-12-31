﻿using Infow.Shared.Abstractions.Exceptions;

namespace Inflow.Modules.Customers.Core.Exceptions;

internal class CustomerNotFoundException : InflowException
{
    public Guid CustomerId { get; }

    public CustomerNotFoundException(Guid customerId)
        : base($"Customer with ID: '{customerId}' was not found.")
    {
        CustomerId = customerId;
    }
}