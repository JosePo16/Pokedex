using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.API.Infraestructure.Crosscutting.DTO
{
    public class PokemonDTO
    {
        public int Id { get; set; }
        public string Nameenglish { get; set; }
        public string Namejapanese { get; set; }
        public string Namechinese { get; set; }
        public string Namefrench { get; set; }
        public string Type0 { get; set; }
        public string Type1 { get; set; }
        public int BaseHp { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseSpAttack { get; set; }
        public int BaseSpDefense { get; set; }
        public int BaseSpeed { get; set; }

        public string UrlMiniatura { get; set; }
        public string UrlImagen { get; set; }
    }
}
