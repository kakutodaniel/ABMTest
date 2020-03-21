using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XML
{
    public class ExtractValues
    {
        private XmlElement XmlElement { get; set; }

        public ExtractValues(XmlElement xml)
        {
            this.XmlElement = xml;
        }

        public Dictionary<string, string> ExtractTextFromCodes(string[] refCodes)
        {
            var res = new Dictionary<string, string>();

            var references = this.XmlElement.GetElementsByTagName("Reference").Cast<XmlNode>();

            if (!references.Any())
            {
                return res;
            }

            foreach (var item in references)
            {
                if (item.Attributes["RefCode"] == null)
                    continue;

                var refCode = item.Attributes["RefCode"].Value;

                if (refCodes.Contains(refCode))
                {
                    var children = item.ChildNodes.Cast<XmlNode>();

                    if (!children.Any())
                        continue;

                    var oRefText = children.Where(x => x.Name.ToLower() == "reftext");

                    if (!oRefText.Any()) continue;

                    var refTexts = string.Join(", ", oRefText.Select(x => x.InnerText));

                    if (!res.ContainsKey(refCode))
                    {
                        res.Add(refCode, refTexts);
                    }
                    else
                    {
                        res[refCode] += $", {refTexts}";
                    }
                }
            }

            return res;
        }
    }
}
