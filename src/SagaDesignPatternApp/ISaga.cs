namespace SagaDesignPatternApp;

public interface ISaga
{
    Task ExecuteAsync();
    Task CompensateAsync();
}