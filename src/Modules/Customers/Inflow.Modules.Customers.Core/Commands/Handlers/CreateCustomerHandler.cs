using Inflow.Modules.Customers.Core.Domain.Entities;
using Inflow.Modules.Customers.Core.Domain.Repositories;
using Infow.Shared.Abstractions.Commands;
using Infow.Shared.Abstractions.Kernel.ValueObjects;
using Infow.Shared.Abstractions.Time;
using Microsoft.Extensions.Logging;

namespace Inflow.Modules.Customers.Core.Commands.Handlers;

internal sealed class CreateCustomerHandler : ICommandHandler<CreateCustomer>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ILogger<CreateCustomerHandler> _logger;
    private readonly IClock _clock;

    public CreateCustomerHandler(
        ICustomerRepository customerRepository, 
        ILogger<CreateCustomerHandler> logger,
        IClock clock)
    {
        _customerRepository = customerRepository;
        _logger = logger;
        _clock = clock;
    }
    
    public async Task HandleAsync(CreateCustomer command, CancellationToken cancellationToken)
    {
        _ = new Email(command.Email);

        var customer = new Customer(Guid.NewGuid(), command.Email, _clock.CurrentDate());
        await _customerRepository.AddAsync(customer);
        _logger.LogInformation("Created customer with ID: '{id}'", customer.Id);
    }
}