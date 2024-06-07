// namespace OutboxDesignPatternApp;
//
// public class OutboxProcessor : BackgroundService
// {
//     private readonly IServiceProvider _serviceProvider;
//     private readonly ILogger<OutboxProcessor> _logger;
//
//     public OutboxProcessor(IServiceProvider serviceProvider, ILogger<OutboxProcessor> logger)
//     {
//         _serviceProvider = serviceProvider;
//         _logger = logger;
//     }
//
//     protected override async Task ExecuteAsync(CancellationToken stoppingToken)
//     {
//         while (!stoppingToken.IsCancellationRequested)
//         {
//             await ProcessOutboxMessagesAsync(stoppingToken);
//             await Task.Delay(5000, stoppingToken); // 5 saniye bekle
//         }
//     }
//
//     private async Task ProcessOutboxMessagesAsync(CancellationToken stoppingToken)
//     {
//         using (var scope = _serviceProvider.CreateScope())
//         {
//             var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//             var messages = await context.OutboxMessages
//                 .Where(m => m.ProcessedAt == null)
//                 .ToListAsync(stoppingToken);
//
//             foreach (var message in messages)
//             {
//                 try
//                 {
//                     // Mesajı işleyin ve gönderin (örneğin, bir mesajlaşma kuyruğuna gönderin)
//                     await SendMessageAsync(message);
//
//                     // Mesajı işaretleyin
//                     message.ProcessedAt = DateTime.UtcNow;
//                     context.OutboxMessages.Update(message);
//                     await context.SaveChangesAsync(stoppingToken);
//                 }
//                 catch (Exception ex)
//                 {
//                     _logger.LogError(ex, "Failed to process outbox message {MessageId}", message.Id);
//                 }
//             }
//         }
//     }
//
//     private Task SendMessageAsync(OutboxMessage message)
//     {
//         // Mesajı gönderme mantığını buraya ekleyin (örneğin, RabbitMQ, Kafka, vs.)
//         // Bu örnekte sadece bir log yazıyoruz
//         _logger.LogInformation("Sending message: {MessageType}, Payload: {Payload}", message.MessageType, message.Payload);
//         return Task.CompletedTask;
//     }
// }