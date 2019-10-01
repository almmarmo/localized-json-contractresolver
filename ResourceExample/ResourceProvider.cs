using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Text;

namespace ResourceExample
{
    public class ResourceProvider : IResourceProvider
    {
        private readonly ResourceManager resourceManager;
        public ResourceProvider(string baseName, Type resourceType)
        {
            resourceManager = new ResourceManager(baseName, resourceType.Assembly);
        }

        public string GetString(string key, CultureInfo culture)
        {
            return resourceManager.GetString(key, culture);
        }
    }
}
