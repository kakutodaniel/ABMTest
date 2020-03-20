using System;
using System.Collections.Generic;
using System.Linq;

namespace XML.DefaultDocument
{
    public class ExtractValues
    {
        private string XML { get; set; }

        public ExtractValues(string xml)
        {
            this.XML = xml;
        }

        public BaseResponse<Dictionary<string,string>> ExtractTextFromCodes(string[] refCodes)
        {
            var response = new BaseResponse<Dictionary<string, string>>();

            try
            {
                var parse = BaseXMLMethods<InputDocument>.Deserialize(this.XML);
                var res = new Dictionary<string, string>();

                if (parse != null)
                {
                    parse.DeclarationList.ToList()
                        .ForEach(x =>
                        {
                            x.DeclarationHeader.Reference.Where(y => refCodes.Contains(y.RefCode)).ToList()
                            .ForEach(z =>
                            {
                                if (!res.ContainsKey(z.RefCode))
                                {
                                    res.Add(z.RefCode, z.RefText);
                                }
                                else
                                {
                                    res[z.RefCode] += $", {z.RefText}";
                                }
                            });
                        });

                    response.SetSuccess(res);
                }
                else
                {
                    response.SetSuccess(null);
                }

            }
            catch (Exception ex)
            {
                response.SetError(ex.ToString());
            }

            return response;
        }
    }
}
