using Application.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Server.Controllers
{
    public class DataController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;

        public DataController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        [Route("api/data/get-random-marvel-characters")]
        [HttpGet]
        public IEnumerable<MarvelCharacter> GetRandomCharacters()
        {

            Random random = new Random();
            string jsonPath = Path.Combine(hostingEnvironment.ContentRootPath, "AppData", "marvel_characters.json");
            string jsonContent = System.IO.File.ReadAllText(jsonPath);
            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<MarvelCharacterList>(jsonContent);
            List<MarvelCharacter> resultList = new List<MarvelCharacter>();
            while (resultList.Count < 12)
            {
                int characterIndex = random.Next(0, list.Characters.Count());
                if (resultList.Where(x => x.Id == list.Characters[characterIndex].Id).FirstOrDefault() == null)
                {
                    resultList.Add(list.Characters[characterIndex]);
                }
            }

            return resultList;
        }


    }
}
