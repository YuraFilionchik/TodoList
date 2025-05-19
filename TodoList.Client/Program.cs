using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TodoList.Client;
using Blazored.Modal;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddBlazoredModal();
var app = builder.Build();

await app.RunAsync();

#region add anonymous user for testing

#endregion