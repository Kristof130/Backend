using System;
using Gokart.Data;
using Gokart.DTOS;
using Gokart.Entities;
using Gokart.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Gokart.Endpoints;

public static class BerloEndpoints
{
const string GetBerloEndpointName = "GetBerlo"; 
    public static RouteGroupBuilder MapBerloEndpoints(this WebApplication app)
    {
        //Get /berlo
        var group = app.MapGroup("berlo").WithParameterValidation();

        group.MapGet("/", async (GokartkolcsonzoContext dbContext) =>
         await dbContext.Berlo.Select(Berlo => Berlo.ToBerloDto())
                        .AsNoTracking().ToListAsync());

        
        // Get /berlo/1
        /*
        group.MapGet("/{id}", async (int id, GokartkolcsonzoContext dbContext) =>
        {
            Berlo? berlo = await dbContext.Berlo.FindAsync(id);

            return berlo is null ? Results.NotFound() : Results.Ok(berlo.ToGameDetailsDto());
        });
*/
        //Post /berlo
        group.MapPost("/", async (CreateBerloDto newBerlo, GokartkolcsonzoContext dbContext) =>
        {
            Berlo berlo = newBerlo.ToEntity();

            dbContext.Berlo.Add(berlo);
            await dbContext.SaveChangesAsync();

        return Results.CreatedAtRoute(GetBerloEndpointName, new { id = berlo.id }, berlo.ToBerloDto());
        });

        

        // Delete /games/1

        group.MapDelete("/{id}", async (int id ,GokartkolcsonzoContext dbContex) =>
        {
           await dbContex.Berlo.Where(berlo => berlo.id == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}
