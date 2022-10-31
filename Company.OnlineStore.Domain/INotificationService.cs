using System;
using System.Threading.Tasks;

namespace Company.OnlineStore.Domain
{
    public interface INotificationService
    {
        Task NotifyCustomer(Guid customerId, Receipt receipt);
    }
}
