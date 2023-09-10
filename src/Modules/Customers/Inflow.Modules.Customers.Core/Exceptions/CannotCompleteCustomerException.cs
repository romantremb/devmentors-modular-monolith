﻿using Infow.Shared.Abstractions.Exceptions;

namespace Inflow.Modules.Customers.Core.Exceptions;

internal class CannotCompleteCustomerException : InflowException
{
    public Guid CustomerId { get; }

    public CannotCompleteCustomerException(Guid customerId)
        : base($"Customer with ID: '{customerId}' cannot be completed.")
    {
        CustomerId = customerId;
    }
}