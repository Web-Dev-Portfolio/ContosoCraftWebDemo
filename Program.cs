using ContosoCraft.Website.Models;
using ContosoCraft.Website.Services;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();
builder.Services.AddTransient<JsonFileProductsService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapBlazorHub();
});

app.MapRazorPages();


app.Run();

// https://github.com/dotnet-presentations
// Setting for CSS
// copy all site.css code from repo
// copy all content inside lib folder for bootstrap
// take header and script code from _Layout.cshtml
// take code starting at beginning until before @code from ProductList.razor
// fix all errors regarding namespace

