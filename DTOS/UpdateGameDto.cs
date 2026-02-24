using System.ComponentModel.DataAnnotations;
//Template!!!!!!!!!!!!!!!!!!!!!!!!!
namespace GameStore.DTOS;

public record class UpdateGamedto(
    [Required][StringLength(50)]string Name,
    int GenreId,
    [Range(1,100)]decimal Price,
    DateOnly ReleaseDate
);
