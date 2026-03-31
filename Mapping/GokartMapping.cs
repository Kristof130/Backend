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

     public static Gokartok ToEntity(this UpdateGokartDto gokart, int id)
    {
        return new Gokartok()
        {   
            Id = id,
            Gyarto = gokart.Gyarto,
            Tipus = gokart.Tipus,
            Evjarat = gokart.Evjarat,
            VazTipusa = gokart.VazTipusa,
            Tomeg = gokart.Tomeg,
            Hossz = gokart.Hossz,
            Szelesseg = gokart.Szelesseg,
            Tengelytav = gokart.Tengelytav,
            MotorTipusa = gokart.MotorTipusa,
            Teljesitmeny = gokart.Teljesitmeny,
            HajtasModja = gokart.HajtasModja,
            ValtoTipusa = gokart.ValtoTipusa,
            Foglalt_e = gokart.Foglalt_e,
            NapiAr = gokart.NapiAr
        };
    } 

    

     public static GokartDto ToGokartDto(this Gokartok gokart)
    {
        return  new(
                 gokart.Id,
                 gokart.Gyarto,
                 gokart.Tipus,
                 gokart.Evjarat,
                 gokart.VazTipusa,
                 gokart.Tomeg,
                 gokart.Hossz,
                 gokart.Szelesseg,
                 gokart.Tengelytav,
                 gokart.MotorTipusa,
                 gokart.Teljesitmeny,
                 gokart.HajtasModja,
                 gokart.ValtoTipusa,
                 gokart.Foglalt_e,
                 gokart.NapiAr
             );
        }
   }

