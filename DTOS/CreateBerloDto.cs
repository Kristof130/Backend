using System.ComponentModel.DataAnnotations;
namespace GameStore.DTOS;

public record class CreateBerloDto(
    [Required]  string Berlo_Neve
);

   

