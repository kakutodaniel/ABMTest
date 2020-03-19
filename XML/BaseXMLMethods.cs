using System.IO;
using System.Xml.Serialization;

namespace XML
{
    public class BaseXMLMethods<T> where T : class, new()
    {

        public static T Deserialize(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var reader = new StringReader(xml))
            {
                return (T)(serializer.Deserialize(reader));
            }
        }

    }
}
