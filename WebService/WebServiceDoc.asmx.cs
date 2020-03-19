using System.IO;
using System.Web.Services;
using System.Xml.Serialization;

namespace WebService
{
    /// <summary>
    /// Summary description for WebServiceDoc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDoc : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string xml)
        {
            var serializer = new XmlSerializer(typeof(InputDocument));
            InputDocument doc;

            using (var reader = new StringReader(xml))
            {
                doc = (InputDocument)(serializer.Deserialize(reader));
            }

            return doc.DeclarationList.Declaration.Command.ToLower() != "default"
                ? "-1"
                : doc.DeclarationList.Declaration.DeclarationHeader.SiteID.ToLower() != "dub"
                ? "-2"
                : "0";
        }
    }

}
