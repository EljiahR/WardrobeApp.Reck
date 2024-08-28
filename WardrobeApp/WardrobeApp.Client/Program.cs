using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WardrobeApp.Client.Services;
using WardrobeApp.Shared.Interfaces;
using static System.Net.WebRequestMethods;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress ?? "https://localhost:7102")
    });
// builder.Services.AddScoped<IWardrobeService, ClientWardrobeService>(); @inject IWardrobeService causing prerender to take too long to load

await builder.Build().RunAsync();
