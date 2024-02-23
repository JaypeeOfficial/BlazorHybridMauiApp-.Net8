using BlazorMauiSampleApp.Data;
using BlazorSampleApp.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Networking;
using SharedClassLibrary.Infrastructure.Services;
using SharedClassLibrary.Infrastructure.Store_Context;
using SharedRazorLibrary.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddSingleton<TodoService>();
builder.Services.AddSingleton<IConnectivity, BlazorConnectivity>();

builder.Services.AddSingleton<IAppServices, AppService>();


var connectionString = builder.Configuration.GetConnectionString("DevConnection");
builder.Services.AddDbContext<StoreContext>(x => x.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(Todo).Assembly);

app.Run();

public class BlazorConnectivity : IConnectivity
{
    public IEnumerable<ConnectionProfile> ConnectionProfiles => null;

    public NetworkAccess NetworkAccess => NetworkAccess.Internet;

    public event EventHandler<ConnectivityChangedEventArgs> ConnectivityChanged;
}