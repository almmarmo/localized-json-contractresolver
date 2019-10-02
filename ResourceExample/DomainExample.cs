using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ResourceExample
{
    public class DomainExample
    {
        [DataMember(Name="nome", EmitDefaultValue = false)]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public List<Person> Cast { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
