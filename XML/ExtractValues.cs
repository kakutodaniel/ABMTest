using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XML
{
    public class ExtractValues
    {
        private XmlDocument XmlDocument { get; set; }

        /// <summary>
        /// contructor. Must input a valid xmlDocument
        /// </summary>
        /// <param name="xml"></param>
        public ExtractValues(XmlDocument xml)
        {
            this.XmlDocument = xml;
        }

        public Dictionary<string, string> ExtractTextFromCodes(string[] refCodes)
        {
            var res = new Dictionary<string, string>();

            //search Reference tag
            var references = this.XmlDocument.GetElementsByTagName("Reference").Cast<XmlNode>();

            //if there is no Reference tag, return empty
            if (!references.Any())
            {
                return res;
            }

            //loop in Reference tags
            foreach (var item in references)
            {
                //if there is no RefCode attribute, go to next item
                if (item.Attributes["RefCode"] == null)
                    continue;

                //get the RefCode value
                var refCode = item.Attributes["RefCode"].Value;

                //check if contains in informed array (by parameter)
                if (refCodes.Contains(refCode))
                {
                    //cast on child nodes
                    var children = item.ChildNodes.Cast<XmlNode>();

                    //if there is no child element, go to next item
                    if (!children.Any())
                        continue;

                    //get RefText child item
                    var oRefText = children.Where(x => x.Name.ToLower() == "reftext");

                    //if there is no RefText, go to next item
                    if (!oRefText.Any()) continue;

                    //join all innertext from RefText found
                    var refTexts = string.Join(", ", oRefText.Select(x => x.InnerText));

                    //check if already exists in the Dictionary
                    //if doesn't exist add it otherwise concat the values
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
