using System;
using Gokart.Data;
using Gokart.DTOS;
using Gokart.Entities;
using Gokart.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Gokart.Endpoints;

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
        // Put /berles/1
        group.MapPut("/{id}", async (int id, UpdateBerlesDto updatedBerles, GokartkolcsonzoContext dbContext) =>
        {
            var existingBerles = await dbContext.Berles.FindAsync(id);
            if (existingBerles is null)
            {
                return Results.NotFound();
            }

            dbContext.Entry(existingBerles).CurrentValues.SetValues(updatedBerles.ToEntity(id));
            await dbContext.SaveChangesAsync();
            return Results.NoContent();
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
