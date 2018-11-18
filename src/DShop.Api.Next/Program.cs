using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NGate;

namespace DShop.Api.Next
{
    public static class Program
    {
        public static async Task Main(string[] args)
            => await WebHost.CreateDefaultBuilder(args).UseNGate().Build().RunAsync();
    }
}
