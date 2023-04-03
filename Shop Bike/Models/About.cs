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
        public string Message => "This application is a " +
            " E-commerce bicycle mobile app which offers different kind of bikes. The app is " +
            "developed using .Net MAUI with MVVM software design pattern and MAUI Community Toolkits.";

    }
}
