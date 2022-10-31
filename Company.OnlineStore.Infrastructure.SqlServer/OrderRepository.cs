using System.Threading.Tasks;
using Company.OnlineStore.Application.Order;
using Company.OnlineStore.Domain.Order;

namespace Company.OnlineStore.Infrastructure.SqlServer
{
    public class OrderRepository : IOrderRepository
    {
        public Task Save(Order order)
        {
            return Task.CompletedTask;
        }
    }
}