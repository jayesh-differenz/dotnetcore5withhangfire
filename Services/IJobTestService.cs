namespace hangfire_dotnetcore_demo.Services
{
    public interface IJobTestService
    {
        void FireAndForgetJob();
        void RecurringJob();
        void DelayedJob();
        void ContinuationJob();
    }
}
