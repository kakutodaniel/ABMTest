using System;
using System.Linq;
using System.Text;

namespace XML.DefaultDocument
{
    public class ExtractValues
    {
        private string XML { get; set; }

        public ExtractValues(string xml)
        {
            this.XML = xml;
        }

        public BaseResponse<string> ExtractTextFromCodes(string[] refCodes)
        {
            var response = new BaseResponse<string>();

            try
            {
                var parse = BaseXMLMethods<InputDocument>.Deserialize(this.XML);

                var res = new StringBuilder();

                if (parse != null)
                {
                    parse.DeclarationList.Declaration.DeclarationHeader.Reference
                            .Where(x => refCodes.Contains(x.RefCode))
                            .ToList()
                            .ForEach(y => res.Append($"{y.RefCode}: {y.RefText}{Environment.NewLine}"));

                    response.SetSuccess(res.ToString());
                }
                else
                {
                    response.SetSuccess("object is null!");
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
