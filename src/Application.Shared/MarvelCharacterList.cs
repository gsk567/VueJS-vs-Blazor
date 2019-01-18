using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Shared
{
    public class MarvelCharacterList
    {
        [JsonProperty("characters")]
        public List<MarvelCharacter> Characters { get; set; }
    }
}
