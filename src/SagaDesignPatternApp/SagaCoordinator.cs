namespace SagaDesignPatternApp;

public class SagaCoordinator : ISagaCoordinator
{
    public async Task StartSagaAsync(ISaga saga)
    {
        try
        {
            await saga.ExecuteAsync();
        }
        catch (Exception)
        {
            await saga.CompensateAsync();
            throw;
        }
    }
}