using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace ResourceExample
{
    public class LocalizedContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            property.PropertyName = ResourceSingleton.Instance.GetString(property.PropertyName, CultureInfo.CreateSpecificCulture("en"));

            return property;
        }
    }
}
