using System;
using System.Threading.Tasks;
using Company.OnlineStore.Application.ShoppingBasket;
using Company.OnlineStore.Domain;

namespace Company.OnlineStore.Application.Order.PlaceOrder
{
    public class PlaceOrderUseCase
    {
        private readonly IShoppingBasketRepository _shoppingBasketRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IPaymentService _paymentService;
        private readonly IReceiptRepository _receiptRepository;
        private readonly INotificationService _notificationService;

        public PlaceOrderUseCase(
            IShoppingBasketRepository shoppingBasketRepository,
            IOrderRepository orderRepository,
            IPaymentService paymentService,
            IReceiptRepository receiptRepository,
            INotificationService notificationService)
        {
            _shoppingBasketRepository = shoppingBasketRepository;
            _orderRepository = orderRepository;
            _paymentService = paymentService;
            _receiptRepository = receiptRepository;
            _notificationService = notificationService;
        }

        public async Task<PlaceOrderResult> Execute(Guid basketId)
        {
            var shoppingBasket = await _shoppingBasketRepository.GetById(basketId);

            var order = shoppingBasket.ConvertToOrder();

            await _orderRepository.Save(order);

            var receipt = await _paymentService.Charge(order);

            await _receiptRepository.Save(receipt);

            await _notificationService.NotifyCustomer(order.CustomerId, receipt);

            return new PlaceOrderResult
            {
                OrderId = order.Id
            };
        }
    }
}
