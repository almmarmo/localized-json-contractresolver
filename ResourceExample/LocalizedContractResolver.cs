using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Globalization;
using System.Reflection;

namespace ResourceExample
{
    public class LocalizedContractResolver : DefaultContractResolver
    {
        private readonly IResourceProvider provider;
        private readonly string culture;

        public LocalizedContractResolver(IResourceProvider provider, string culture)
        {
            this.provider = provider;
            this.culture = culture;
        }
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            var localized = provider.GetString(member.ReflectedType.Name + "_" + property.PropertyName, CultureInfo.GetCultureInfo(culture));
            if (!String.IsNullOrEmpty(localized))
                property.PropertyName = localized;

            return property;
        }
    }
}
