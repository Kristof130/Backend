using System.ComponentModel.DataAnnotations;
namespace Gokart.DTOS;

public record class CreateBerlesDto
(
    [Required] int Gokart_Id,
    [Required] int Berlo_Id,
    [Required] DateOnly KezdoDatum,
    [Required] int Berles_hossza
);
