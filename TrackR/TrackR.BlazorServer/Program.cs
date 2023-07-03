using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrackR.BlazorServer.Services; // BoardService
using TrackR.DataContext.SQL; // AddSqlContext()

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// Add DB
builder.Services.AddSqlContext();

builder.Services.AddTransient<BoardService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();