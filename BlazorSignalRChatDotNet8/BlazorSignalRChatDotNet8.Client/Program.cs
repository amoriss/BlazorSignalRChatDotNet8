using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddSingleton<IJSRuntime, JSRuntime>();

await builder.Build().RunAsync();
