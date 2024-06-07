namespace SagaDesignPatternApp;

// OrderSaga
public class OrderSaga : ISaga
{
    private readonly Order _order;

    public OrderSaga(Order order)
    {
        _order = order;
    }

    public async Task ExecuteAsync()
    {
        await CreateOrderAsync();
        await ProcessPaymentAsync();
        await UpdateInventoryAsync();
        await SendNotificationAsync();
    }

    public async Task CompensateAsync()
    {
        await CompensateSendNotificationAsync();
        await CompensateUpdateInventoryAsync();
        await CompensateProcessPaymentAsync();
        await CompensateCreateOrderAsync();
    }

    private async Task CreateOrderAsync()
    {
        // Siparişi oluştur
    }

    private async Task ProcessPaymentAsync()
    {
        // Ödemeyi işle
    }

    private async Task UpdateInventoryAsync()
    {
        // Stok güncelle
    }

    private async Task SendNotificationAsync()
    {
        // Bildirim gönder
    }

    private async Task CompensateCreateOrderAsync()
    {
        // Siparişi geri al
    }

    private async Task CompensateProcessPaymentAsync()
    {
        // Ödemeyi geri al
    }

    private async Task CompensateUpdateInventoryAsync()
    {
        // Stok güncellemeyi geri al
    }

    private async Task CompensateSendNotificationAsync()
    {
        // Bildirimi geri al
    }
}