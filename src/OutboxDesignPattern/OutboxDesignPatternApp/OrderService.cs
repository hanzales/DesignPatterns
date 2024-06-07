namespace OutboxDesignPatternApp;

public class OrderService
{
    
    //Veritabanı işlemi sırasında, Outbox tablosuna bir mesaj ekle
    
    public async Task CreateOrderAsync(Order order)
    {
        //using (var transaction = await _context.Database.BeginTransactionAsync())
        // {
        //     try
        //     {
        //         // Siparişi oluştur
        //         //_context.Orders.Add(order);
        //         //await _context.SaveChangesAsync();
        //
        //         // Outbox mesajı oluştur
        //         var outboxMessage = new OutboxMessage
        //         {
        //             Id = Guid.NewGuid(),
        //             CreatedAt = DateTime.UtcNow,
        //             MessageType = "OrderCreated",
        //             Payload = JsonConvert.SerializeObject(order)
        //         };
        //         _context.OutboxMessages.Add(outboxMessage);
        //         await _context.SaveChangesAsync();
        //
        //         await transaction.CommitAsync();
        //     }
        //     catch (Exception)
        //     {
        //         await transaction.RollbackAsync();
        //         throw;
        //     }
        // }
    }
}