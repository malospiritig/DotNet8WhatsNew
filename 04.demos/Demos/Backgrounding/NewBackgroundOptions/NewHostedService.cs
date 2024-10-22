
namespace NewBackgroundOptions
{
    public class NewHostedService : IHostedLifecycleService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(StartAsync));
            return Task.CompletedTask;
        }

        public Task StartedAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(StartedAsync));
            return Task.CompletedTask; 
        }

        public Task StartingAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(StartingAsync));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(StopAsync));
            return Task.CompletedTask;
        }

        public Task StoppedAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(StoppedAsync));
            return Task.CompletedTask;
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(nameof(StoppingAsync));
            return Task.CompletedTask;
        }
    }
}
