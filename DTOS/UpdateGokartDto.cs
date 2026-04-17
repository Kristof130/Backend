namespace Gokart.DTOS;

public record class UpdateGokartDto
(
    string Gyarto,
    string Tipus,
    DateOnly Evjarat,
    string VazTipusa,
    int Tomeg,
    int Hossz,
    int Szelesseg,
    int Tengelytav,
    string MotorTipusa,
    int Teljesitmeny,
    string HajtasModja,
    string ValtoTipusa,
    int Foglalt_e,
    int NapiAr
);
