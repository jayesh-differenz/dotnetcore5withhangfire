namespace hangfire_dotnetcore_demo.Services
{
    public class JobTestService : IJobTestService
    {
        public void ContinuationJob()
        {
            Console.WriteLine("Hello from a Continuation Job");
        }

        public void DelayedJob()
        {
            Console.WriteLine("Hello from a Delayed Job");
        }

        public void FireAndForgetJob()
        {
            Console.WriteLine("Hello from a FireAndForget Job");
        }

        public void RecurringJob()
        {
            Console.WriteLine("Hello from a Recurring Job");
        }
    }
}
