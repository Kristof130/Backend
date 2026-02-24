using System;
using GameStore.Data;
using GameStore.DTOS;
using GameStore.Entities;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class GokartEndpoints
{
const string GetGameEndpointName = "GetGame"; 
    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {
        //Get /games
        var group = app.MapGroup("games").WithParameterValidation();

        group.MapGet("/", async (GokartkolcsonzoContext dbContext) =>
         await dbContext.Gokart.Select(gokart => gokart.ToGokartDto())
                        .AsNoTracking().ToListAsync());
          
        // Get /games/1
        group.MapGet("/{id}", async (int id, GokartkolcsonzoContext dbContext) =>
        {
            Gokart? gokart = await dbContext.Gokart.FindAsync(id);

            return gokart is null ? Results.NotFound() : Results.Ok(gokart.ToGokartDto());
        });


        // Put /games/1
        group.MapPut("/{id}", async (int id, UpdateGokartDto updatedGokart, GokartkolcsonzoContext dbContex) =>
        {
            var existingGokart = await dbContex.Gokart.FindAsync(id);
            if (existingGokart is null)
            {
                return Results.NotFound();
            }

            dbContex.Entry(existingGokart).CurrentValues.SetValues(updatedGokart.ToEntity(id));
            await dbContex.SaveChangesAsync();
            return Results.NoContent();
        });

        // Delete /games/1

        group.MapDelete("/{id}", async (int id,GokartkolcsonzoContext dbContex) =>
        {
           await dbContex.Gokart.Where(gokart => gokart.Gokart_Id == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}
