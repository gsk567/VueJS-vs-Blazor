using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Shared
{
    public class MarvelCharacter
    {
        public MarvelCharacter()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }
}
