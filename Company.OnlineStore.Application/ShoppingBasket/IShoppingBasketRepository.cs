using System;
using System.Threading.Tasks;

namespace Company.OnlineStore.Application.ShoppingBasket
{
    public interface IShoppingBasketRepository
    {
        Task<Domain.ShoppingBasket.ShoppingBasket> GetById(Guid shoppingBasketId);
    }
}