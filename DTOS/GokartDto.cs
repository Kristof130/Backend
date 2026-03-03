namespace GameStore.DTOS;

public record class GokartDto
(
int Id,
string Gyarto,
string Tipus,
DateOnly Evjarat,
string VazTipusa,
int Tomeg,
int Hossz,
int Szelesseg,
int Tengelytav,
string MotorTipusa,
string HajtasModja,
string ValtoTipusa,
bool Foglalt_e,
int NapiAr
);
