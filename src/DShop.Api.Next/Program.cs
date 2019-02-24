using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Ntrada;
using Ntrada.Extensions.RabbitMq;

namespace DShop.Api.Next
{
    public static class Program
    {
        public static async Task Main(string[] args)
            => await WebHost.CreateDefaultBuilder(args)
                .UseNtrada()
                .UseRabbitMq()
                .Build()
                .RunAsync();
    }
}
