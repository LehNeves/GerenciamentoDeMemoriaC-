using System.Globalization;

namespace GerenciamentoDeMemoria;

internal class Coordenada
{
    public Coordenada(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public override string ToString()
    {
        return $"{Latitude.ToString(CultureInfo.InvariantCulture)}, {Longitude.ToString(CultureInfo.InvariantCulture)}";
    } 
}

// Structs não podem utilizar Herança
// mas podem implementar intefaces,
// porém ao utilizar intefaces, pode haver boxing e unboxing
// Structs são guardadas na Stack
internal struct CoordenadaStruct
{
    public CoordenadaStruct()
    {
    }

    public CoordenadaStruct(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double Latitude { get; set; }
    public double Longitude { get; set; }
}