using GitHub;
using System.Threading.Tasks;
using Serilog;

namespace POC
{
    public class ResultPublisher : IResultPublisher
    {
        public Task Publish<T>(Result<T> result)
        {
            var logger = new LoggerConfiguration()
                    .WriteTo.ColoredConsole()
                    .CreateLogger();

        }
    }
}
