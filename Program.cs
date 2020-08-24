using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MappingsSquad
{
    public class Program
    {
        public static string BaseAddress = "https://innovationapiteame.zambion.com";//"https://localhost:44360/"; //
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(BaseAddress/*builder.HostEnvironment.BaseAddress*/) });

            builder.Services.AddBlazoredSessionStorage(config => config.JsonSerializerOptions.WriteIndented = true);

            await builder.Build().RunAsync();
        }
    }
}
