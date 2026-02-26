using Microsoft.EntityFrameworkCore;
using GameStore.Data;
using GameStore.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddDbContext<GokartkolcsonzoContext>(options =>
    options.UseMySql(connString, ServerVersion.AutoDetect(connString)));
var app = builder.Build();

app.MapBerlesEndpoints(); 
app.MapBerloEndpoints();
app.MapGokartEndpoints();

await app.MigrateDB();

app.Run();
