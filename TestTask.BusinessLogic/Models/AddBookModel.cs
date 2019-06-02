using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace TestTask.BusinessLogic.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class AddBookModel
    {
        public string Title { get; set; }

        public string Author { get; set; }
    }
}
