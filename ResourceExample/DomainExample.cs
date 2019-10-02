using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ResourceExample
{
    public class DomainExample
    {
        [DataMember(Name="nome")]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public List<Person> Cast { get; set; }

        public int Id { get; set; }
    }

    public class Person
    {
        [DataMember(Name = "Code")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
