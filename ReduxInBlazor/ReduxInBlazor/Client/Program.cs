using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ReduxInBlazor.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Add following for fluxor
var currentAssembly = typeof(Program).Assembly;
builder.Services.AddFluxor(options => 
{
    options.ScanAssemblies(currentAssembly);
    //options.UseDependencyInjection(typeof(Startup).Assembly);
    //options.AddMiddleware<ReduxDevToolsMiddleware>();
    //options.AddMiddleware<RoutingMiddleware>();
});

await builder.Build().RunAsync();
