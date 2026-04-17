using Microsoft.EntityFrameworkCore;

namespace Gokart.Data;

public static class DataExtensions
{
    public static async Task MigrateDB(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GokartkolcsonzoContext>();
        await dbContext.Database.MigrateAsync();
    }
}
