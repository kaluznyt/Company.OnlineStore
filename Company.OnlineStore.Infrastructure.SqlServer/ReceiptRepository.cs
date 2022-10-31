using System.Threading.Tasks;
using Company.OnlineStore.Application;
using Company.OnlineStore.Domain;

namespace Company.OnlineStore.Infrastructure.SqlServer
{
    public class ReceiptRepository : IReceiptRepository
    {
        public Task Save(Receipt receipt)
        {
            return Task.CompletedTask;
        }
    }
}