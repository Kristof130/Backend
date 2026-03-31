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
            Gokart_Id = berles.Gokart_Id,
            Berlo_Id = berles.Berlo_Id,
            Berles_hossza = berles.Berles_hossza,
            KezdoDatum = berles.KezdoDatum
        };
    }   

     public static Berles ToEntity(this UpdateBerlesDto berles, int id)
    {
        return new Berles()
        {   
            ID = id,
            Gokart_Id = berles.Gokart_Id,
            Berlo_Id = berles.Berlo_Id,
            Berles_hossza = berles.Berles_hossza,
            KezdoDatum = berles.KezdoDatum
        };
    }
     

    public static BerlesDto ToBerlesDto(this Berles berles)
    {
        return new BerlesDto(
                berles.ID,
                berles.Gokart_Id,
                berles.Berlo_Id,                
                berles.KezdoDatum,
                berles.Berles_hossza
                
            );
    }
}
