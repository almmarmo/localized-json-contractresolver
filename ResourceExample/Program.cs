using Newtonsoft.Json;
using NewtonSoft.Globalization;
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
                Name = "Nome na entidade",
                Date = DateTime.Now,
                Cast = new System.Collections.Generic.List<Person>() { new Person { Name="Elenco 1"}, new Person { Name = "Elenco 2" } }
            };
            //entity.Nome = null;

            ResourceProvider provider = new ResourceProvider("ResourceExample.Resources.Domain", typeof(Resources.Domain));

            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore,  ContractResolver = new ResourceContractResolver(provider, "en") };
            var json = JsonConvert.SerializeObject(entity, settings);

            var settingsBr = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, ContractResolver = new ResourceContractResolver(provider, "pt-br") };
            var jsonBr = JsonConvert.SerializeObject(entity, settingsBr);

            Console.WriteLine(json);
            Console.WriteLine(jsonBr);
        }
    }
}
