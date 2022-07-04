using System.Threading.Tasks;

namespace App1.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
