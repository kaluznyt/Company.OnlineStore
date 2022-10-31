using System.Threading.Tasks;

namespace Company.OnlineStore.Application.Order
{
    public interface IOrderRepository
    {
        Task Save(Domain.Order.Order order);
    }
}
