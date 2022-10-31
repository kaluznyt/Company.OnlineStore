using System.Threading.Tasks;

namespace Company.OnlineStore.Domain
{
    public interface IPaymentService
    {
        Task<Receipt> Charge(Order.Order order);
    }
}
