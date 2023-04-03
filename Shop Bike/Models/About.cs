using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Bike.Models
{
    public class About
    {
        public string Name => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://en.wikipedia.org/wiki/Bicycle";
        public string Message => "This app is written in XAML and C# with .NET MAUI.";

    }
}
