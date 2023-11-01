// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.ComTypes;

var builder = WebApplication.CreateBuilder();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapFallbackToFile("index.html");

app.MapGet("/hello", (CancellationToken ct) => "Do you remember me?");

app.Run();