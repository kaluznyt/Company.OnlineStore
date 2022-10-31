using System.Threading.Tasks;
using Company.OnlineStore.Domain;

namespace Company.OnlineStore.Application
{
    public interface IReceiptRepository
    {
        Task Save(Receipt receipt);
    }
}