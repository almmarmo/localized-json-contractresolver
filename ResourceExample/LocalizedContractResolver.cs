using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Globalization;
using System.Reflection;

namespace ResourceExample
{
    public class LocalizedContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            var localized = ResourceSingleton.Instance.GetString(member.ReflectedType.Name + "_" + property.PropertyName, CultureInfo.CreateSpecificCulture("en"));
            if (!String.IsNullOrEmpty(localized))
                property.PropertyName = localized;

            return property;
        }
    }
}
