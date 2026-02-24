using System;
using GameStore.DTOS;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class GokartMapping
{
    /*public static Game ToEntity(this creategameDto game)
    {
        return new Game()
        {
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    } */  

     public static Gokart ToEntity(this UpdateGokartDto gokart, int id)
    {
        return new Gokart()
        {   
            Gokart_Id = id,
            Foglalt_e = gokart.Foglalt_e
        };
    } 

    

     public static GokartDto ToGokartDto(this Gokart gokart)
    {
        return  new(
                 gokart.Gokart_Id,
                 gokart.Gyarto,
                 gokart.Tipus,
                 gokart.Evjarat,
                 gokart.VazTipusa,
                 gokart.Tomeg,
                 gokart.Hossz,
                 gokart.Szelesseg,
                 gokart.Tengelytav,
                 gokart.MotorTipusa,
                 gokart.HajtasModja,
                 gokart.ValtoTipusa,
                 gokart.Foglalt_e,
                 gokart.NapiAr
             );
        }
   }

