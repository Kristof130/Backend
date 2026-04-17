using System.ComponentModel.DataAnnotations;
//Template!!!!!!!!!!!!!!!!!!!!!!!!!
namespace Gokart.DTOS;

    public record class creategameDto(
     [Required][StringLength(50)] string Name,
     int GenreId,
     [Range(1,100)]decimal Price,
     DateOnly ReleaseDate
);
