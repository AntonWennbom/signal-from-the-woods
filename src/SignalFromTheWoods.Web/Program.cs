using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SignalFromTheWoods.Application.Abstractions;
using SignalFromTheWoods.Application.Services;
using SignalFromTheWoods.Web;
using SignalFromTheWoods.Web.Infrastructure;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<IClock, SystemClock>();
builder.Services.AddScoped<UnlockService>();
builder.Services.AddScoped<CultureService>();
builder.Services.AddLocalization();

var host = builder.Build();

await host.Services.GetRequiredService<CultureService>().InitializeAsync();

await host.RunAsync();
