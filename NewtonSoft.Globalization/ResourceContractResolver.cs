using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;

namespace NewtonSoft.Globalization
{
    public class ResourceContractResolver : DefaultContractResolver
    {
        private readonly IResourceProvider provider;
        private readonly string culture;

        public ResourceContractResolver(IResourceProvider provider, string culture)
        {
            this.provider = provider;
            this.culture = culture;
        }
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            var datamember = member.GetCustomAttribute<DataMemberAttribute>();

            if (datamember != null)
                property.PropertyName = datamember.Name ?? property.PropertyName;

            var localized = provider.GetString(property.PropertyName, CultureInfo.GetCultureInfo(culture));
            if (!String.IsNullOrEmpty(localized))
                property.PropertyName = localized;

            return property;
        }
    }
}
