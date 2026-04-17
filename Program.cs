using Microsoft.EntityFrameworkCore;
using Gokart.Data;
using Gokart.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GokartKolcsonzo");
builder.Services.AddDbContext<GokartkolcsonzoContext>(options =>
    options.UseMySql(connString, ServerVersion.AutoDetect(connString)));
var app = builder.Build();

app.MapBerlesEndpoints(); 
app.MapBerloEndpoints();
app.MapGokartEndpoints();

//await app.MigrateDB();

app.Run();
