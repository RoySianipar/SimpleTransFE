using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SempurnaFE;
using SempurnaFE.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44353/") });

builder.Services.AddScoped<TransactionService>();


//builder.Services.AddHttpClient<TransactionService>(client =>
//{
//    client.BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"]);  // Ganti dengan URL backend kamu
//});


await builder.Build().RunAsync();
