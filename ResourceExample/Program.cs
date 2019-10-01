using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Resources;

namespace ResourceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var entity = new DomainExample()
            {
                Nome = "teste",
                Data = DateTime.Now
            };

            ResourceProvider provider = new ResourceProvider("ResourceExample.Resources.Domain", typeof(Resources.Domain));

            var settings = new JsonSerializerSettings { ContractResolver = new LocalizedContractResolver(provider, "en-us") };
            var json = JsonConvert.SerializeObject(entity, settings);

            Console.WriteLine(json);
        }
    }
}
