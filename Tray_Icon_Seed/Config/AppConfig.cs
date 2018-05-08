using System.ComponentModel;
using System.Xml.Serialization;

namespace Tray_Icon_Seed.Config
{
    [XmlRoot("Configs")]
    public class AppConfig : ConfigBase<AppConfig>
    {
        public AppConfig()
        {
            Myconfig = "MyConig";
        }

        //Your configuration here
        public string Myconfig { get; set; }

        [XmlIgnore]
        [Browsable(false)]
        public static AppConfig Config { get; set; }
    }
}
