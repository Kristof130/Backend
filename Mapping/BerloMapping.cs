using System;
using GameStore.DTOS;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class BerloMapping
{
public static Berlo ToEntity(this CreateBerloDto berlo)
    {
        return new Berlo()
        {
            Berlo_Neve = berlo.Berlo_Neve

        };
    }   

     /*public static Game ToEntity(this UpdateGamedto game, int id)
    {
        return new Game()
        {   
            Id = id,
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    } */

   

     public static BerloDto ToBerloDto(this Berlo berlo)
    {
        return new BerloDto(
                berlo.Berlo_Id,
                berlo.Berlo_Neve
            );
    }
}
