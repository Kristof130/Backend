using System;
using GameStore.DTOS;
using GameStore.Entities;


namespace GameStore.Mapping;

public static class BerlesMapping
{
 public static Berles ToEntity(this CreateBerlesDto berles)
    {
        return new Berles()
        {
            Berlo_Id = berles.Berlo_Id,
            Gokart_Id = berles.Gokart_Id,
            Berles_hossza = berles.Berles_hossza,
            KezdoDatum = berles.KezdoDatum
        };
    }   

    /* public static Game ToEntity(this UpdateGamedto game, int id)
    {
        return new Game()
        {   
            Id = id,
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }*/
     

    public static BerlesDto ToBerlesDto(this Berles berles)
    {
        return new BerlesDto(
                berles.Berlo_Id,
                berles.Gokart_Id,
                berles.KezdoDatum,
                berles.Berles_hossza,
                berles.Berles_ID
            );
    }
}
