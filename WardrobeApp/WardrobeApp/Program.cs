using WardrobeApp.Client.Pages;
using WardrobeApp.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WardrobeApp.Data;
using WardrobeApp.Shared.Interfaces;
using WardrobeApp.Services;
using WardrobeApp.Repositories;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WardrobeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WardrobeContext") ?? throw new InvalidOperationException("Connection string 'WardrobeContext' not found.")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<IWardrobeRepository,  WardrobeRepository>();
builder.Services.AddScoped<IWardrobeService, WardrobeService>();

builder.Services.AddHttpClient();

builder.Services.AddCors(options =>
{
options.AddDefaultPolicy(
   policy =>

			{
	policy.AllowAnyOrigin()
		  .AllowAnyHeader()
			.AllowAnyMethod();
});
    });

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
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
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(WardrobeApp.Client._Imports).Assembly);

app.MapControllers();

app.Run();
