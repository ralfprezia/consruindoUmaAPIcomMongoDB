using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data
{
    public class infectado
    {
        public infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;      //pacote da mongo
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set;}
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}