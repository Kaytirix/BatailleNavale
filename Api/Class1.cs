using System.Net.Http;
using System.Text.Json.Serialization;

namespace Api
{
    public class Class1
    {
        //https://api-lprgi.natono.biz/api/GetConfig

        public class Obj
        {
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("age")]
            public int Age { get; set; }
            [JsonIgnore]
            public DateTime DateNaissance { get; set; }
        }


        string jsonString = "{\"name\": \"toto\", \"age\": 19}";
        Obj DeserializedObject = JsonConvert.DeserializeObject<Obj>(jsonString);

    }
}