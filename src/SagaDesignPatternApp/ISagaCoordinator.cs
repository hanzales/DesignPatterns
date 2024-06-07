namespace SagaDesignPatternApp;

public interface ISagaCoordinator
{
    Task StartSagaAsync(ISaga saga);

}