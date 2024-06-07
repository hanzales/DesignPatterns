namespace OutboxDesignPatternApp;

public class OutboxMessage
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ProcessedAt { get; set; }
    public string MessageType { get; set; }
    public string Payload { get; set; }
}