using System;
using GameStore.Data;
using GameStore.DTOS;
using GameStore.Entities;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class BerlesEndpoints
{
const string GetberlesEndpointName = "GetBerles"; 
    public static RouteGroupBuilder MapBerlesEndpoints(this WebApplication app)
    {
        //Get /Berles
        var group = app.MapGroup("Berles").WithParameterValidation();

        group.MapGet("/", async (GokartkolcsonzoContext dbContext) =>
         await dbContext.Berles.Select(berles => berles.ToBerlesDto())
                            .AsNoTracking().ToListAsync());
          
        // Get /berles/1
        group.MapGet("/{id}", async (int id, GokartkolcsonzoContext dbContext) =>
        {
            Berles? berles = await dbContext.Berles.FindAsync(id);

            return berles is null ? Results.NotFound() : Results.Ok(berles.ToBerlesDto());
        });

        //Post /berles
        group.MapPost("/", async (CreateBerlesDto newBerles, GokartkolcsonzoContext dbContext) =>
        {
            Berles berles = newBerles.ToEntity();

            dbContext.Berles.Add(berles);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetberlesEndpointName, new { id = berles.ID }, berles.ToBerlesDto());
        });

    

        // Delete /berles/1

        group.MapDelete("/{id}", async (int id,GokartkolcsonzoContext dbContex) =>
        {
           await dbContex.Berles.Where(berles => berles.ID == id).ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}
