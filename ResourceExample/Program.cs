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
            var settings = new JsonSerializerSettings { ContractResolver = new LocalizedContractResolver() };
            var json = JsonConvert.SerializeObject(entity, settings);

            Console.WriteLine(json);
        }
    }
}
