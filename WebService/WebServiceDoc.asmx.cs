using System.Web.Services;
using System.Linq;
using System.Web.Services.Protocols;
using System.Xml;

namespace WebService
{
    /// <summary>
    /// Summary description for WebServiceDoc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDoc : System.Web.Services.WebService
    {

        [WebMethod]
        [SoapDocumentMethod(ParameterStyle = SoapParameterStyle.Bare)]
        public string CheckOut(XmlElement input)
        {
            var declarationTags = input.GetElementsByTagName("Declaration").Cast<XmlNode>();

            foreach (var item in declarationTags)
            {
                if (item.Attributes["Command"] == null)
                {
                    continue;
                }

                if (item.Attributes["Command"].Value.ToLower() != "default")
                {
                    return "-1";
                }
            }

            var siteTags = input.GetElementsByTagName("SiteID");

            var existsDiffSites = siteTags.Cast<XmlNode>()
                .Any(y => y.InnerText.ToLower() != "dub");

            if (existsDiffSites)
            {
                return "-2";
            }

            return "0";
        }

    }

}
