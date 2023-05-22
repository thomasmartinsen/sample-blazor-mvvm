using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Vta.Tshirt.Client.Features.Start;
using Vta.Tshirt.Client.Logic.Features.Start;
using Vta.Tshirt.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<ITshirtService, TshirtService>();
builder.Services.AddScoped<StartViewModel>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
