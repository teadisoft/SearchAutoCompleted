using Blazor.ModalDialog;
using BlazorCRUD.Client;
using Blazored.Modal;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44360/") });

builder.Services.AddDevExpressBlazor();
builder.Services.AddModalDialog();

await builder.Build().RunAsync();

