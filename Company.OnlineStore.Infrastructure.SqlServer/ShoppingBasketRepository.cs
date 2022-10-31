using System;
using System.Threading.Tasks;
using Company.OnlineStore.Application.ShoppingBasket;
using Company.OnlineStore.Domain.ShoppingBasket;

namespace Company.OnlineStore.Infrastructure.SqlServer
{
    public class ShoppingBasketRepository : IShoppingBasketRepository
    {
        public async Task<ShoppingBasket> GetById(Guid shoppingBasketId)
        {
            return new ShoppingBasket
            {
                Id = shoppingBasketId
            };
        }
    }
}