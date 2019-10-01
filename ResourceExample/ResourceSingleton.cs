using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace ResourceExample
{
    public class ResourceSingleton
    {
        private static ResourceManager manager;

        public static ResourceManager Instance
        {
            get
            {
                if(manager == null)
                    manager = new ResourceManager("ResourceExample.Resources.Domain", typeof(Resources.Domain).Assembly);

                return manager;
            }
        }
    }
}
