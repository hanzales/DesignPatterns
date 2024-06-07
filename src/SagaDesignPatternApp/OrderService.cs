namespace SagaDesignPatternApp;

public class OrderService
{
    private readonly ISagaCoordinator _sagaCoordinator;

    public OrderService(ISagaCoordinator sagaCoordinator)
    {
        _sagaCoordinator = sagaCoordinator;
    }

    public async Task CreateOrderAsync(Order order)
    {
        // Siparişi veri tabanına kaydet
        // ...

        // Saga başlat
        var saga = new OrderSaga(order);
        await _sagaCoordinator.StartSagaAsync(saga);
    }
}