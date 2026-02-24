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

     public static Gokart ToEntity(this UpdateGokartDto game, int id)
    {
        return new Gokart()
        {   
            Gokart_Id = id,
            Foglalt_e = game.Foglalt_e
        };
    } 

    

     public static GokartDto ToGokartDto(this Gokart gokart)
    {
        return  new GokartDto()
        {
            Gokart_Id = gokart.Gokart_Id,
            Gyarto = gokart.Gyarto,
            Tipus = gokart.Tipus,
            Evjarat = gokart.Evjarat,
            VazTipusa = gokart.VazTipusa,
            Tomeg = gokart.Tomeg,
            Hossz = gokart.Hossz,
            Szelesseg = gokart.Szelesseg,
            Tengelytav = gokart.Tengelytav,
            MotorTipusa = gokart.MotorTipusa,
            HajtasModja = gokart.HajtasModja,
            ValtoTipusa = gokart.ValtoTipusa,
            Foglalt_e = gokart.Foglalt_e,
            NapiAr = gokart.NapiAr
        };
    }
}
