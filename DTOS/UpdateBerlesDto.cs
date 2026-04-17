using System;

namespace Gokart.DTOS;

public record class UpdateBerlesDto
(
    int Gokart_Id,
    int Berlo_Id,
    DateOnly KezdoDatum,
    int Berles_hossza
);
