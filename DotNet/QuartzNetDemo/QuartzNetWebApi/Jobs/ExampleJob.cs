using Quartz;
using System;
using System.Threading.Tasks;

namespace QuartzNetWebApi.Jobs
{
    public class ExampleJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync("Greetings from HelloJob!");
        }
    }
}
