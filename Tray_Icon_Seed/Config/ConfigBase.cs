using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace Tray_Icon_Seed.Config
{
    public abstract class ConfigBase<T>
    {
        public event EventHandler Changed;

        protected virtual void OnChanged()
        {
            var handler = Changed;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        [Browsable(false)]
        [XmlIgnore]
        private static string Path
        {
            get
            {
                return string.Format(@".\{0}.xml", typeof(T).Name);
            }
        }
        public bool Salvar()
        {
            try
            {
                using (var stream = new FileStream(Path, FileMode.Create))
                {
                    var serealizer = new XmlSerializer(typeof(T));
                    serealizer.Serialize(stream, this);
                    OnChanged();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static T Load()
        {
            if (!File.Exists(Path)) return Activator.CreateInstance<T>();
            try
            {
                using (var stream = new FileStream(Path, FileMode.Open))
                {
                    var deserealize = new XmlSerializer(typeof(T));
                    var config = (T)deserealize.Deserialize(stream);
                    return config;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel abrir o arquivo de configuração. Erro: " + ex);
            }
        }
    }
}