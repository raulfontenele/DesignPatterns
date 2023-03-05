using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gerador.XML.Model
{
    public class GeradorXml
    {
        public string Gerar(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
        
    }
}
