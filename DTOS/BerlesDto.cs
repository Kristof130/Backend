namespace Gokart.DTOS;

public record class BerlesDto
(
    int ID,
    int Gokart_Id,
    int Berlo_Id,
    DateOnly KezdoDatum,
    int Berles_hossza
);
