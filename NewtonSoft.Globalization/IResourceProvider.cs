using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NewtonSoft.Globalization
{
    public interface IResourceProvider
    {
        string GetString(string key, CultureInfo culture);
    }
}
