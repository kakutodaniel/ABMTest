using System;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //var xml = @"
            //    <InputDocument>
            //      <DeclarationList>
            //        <Declaration Command='DEFAULT' Version='5.13'>
            //          <DeclarationHeader>
            //            <Jurisdiction>IE</Jurisdiction>
            //            <CWProcedure>IMPORT</CWProcedure>
            //            <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
            //            <DocumentRef>71Q0019681</DocumentRef>
            //            <SiteID>DUB</SiteID>
            //            <AccountCode>G0779837</AccountCode>
            //            <Reference RefCode='MWB'>
            //              <RefText>586133622</RefText>
            //            </Reference>
            //            <Reference RefCode='KEY'>
            //              <RefText>DUB16049</RefText>
            //            </Reference>
            //            <Reference RefCode='CAR'>
            //              <RefText>71Q0019681</RefText>
            //            </Reference>
            //            <Reference RefCode='COM'>
            //              <RefText>71Q0019681</RefText>
            //            </Reference>
            //            <Reference RefCode='SRC'>
            //              <RefText>ECUS</RefText>
            //            </Reference>
            //            <Reference RefCode='TRV'>
            //              <RefText>1</RefText>
            //            </Reference>
            //            <Reference RefCode='CAS'>
            //              <RefText>586133622</RefText>
            //            </Reference>
            //            <Reference RefCode='HWB'>
            //              <RefText>586133622</RefText>
            //            </Reference>
            //            <Reference RefCode='UCR'>
            //              <RefText>586133622</RefText>
            //            </Reference>
            //            <Country CodeType='NUM' CountryType='Destination'>IE</Country>
            //            <Country CodeType='NUM' CountryType='Dispatch'>CN</Country>
            //           </DeclarationHeader>
            //          </Declaration>
            //        <Declaration Command='DEFAULT' Version='5.13'>
            //          <DeclarationHeader>
            //            <Reference RefCode='MWB'>
            //            </Reference>
            //            <Reference RefCode='CAR'>
            //              <RefText>222</RefText>
            //            </Reference>
            //            <Reference RefCode='TRV'>
            //              <RefText>333</RefText>
            //            </Reference>
            //           </DeclarationHeader>
            //          </Declaration>
            //        </DeclarationList>
            //    </InputDocument>";

                 var xml = @"
                <InputDocument>
                  <DeclarationList>
                    <Declaration Command='DEFAULT' Version='5.13'>
                      <DeclarationHeader>
                        <Jurisdiction>IE</Jurisdiction>
                        <CWProcedure>IMPORT</CWProcedure>
                        <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
                        <DocumentRef>71Q0019681</DocumentRef>
                        <SiteID>DUB</SiteID>
                        <AccountCode>G0779837</AccountCode>
                        <Reference RefCode='MWB'>
                            <RefText>1234</RefText>
                            <RefText>5678</RefText>
                        </Reference>
                        <Reference RefCode='KEY'>
                          <RefText>DUB16049</RefText>
                        </Reference>
                        <Reference RefCode='CAR'>
                          <RefText>71Q0019681</RefText>
                        </Reference>
                        <Reference RefCode='COM'>
                          <RefText>71Q0019681</RefText>
                        </Reference>
                        <Reference RefCode='SRC'>
                          <RefText>ECUS</RefText>
                        </Reference>
                        <Reference RefCode='TRV'>
                          <RefText>1</RefText>
                        </Reference>
                        <Reference RefCode='CAS'>
                          <RefText>586133622</RefText>
                        </Reference>
                        <Reference RefCode='HWB'>
                          <RefText>586133622</RefText>
                        </Reference>
                        <Reference RefCode='UCR'>
                          <RefText>586133622</RefText>
                        </Reference>
                        <Country CodeType='NUM' CountryType='Destination'>IE</Country>
                        <Country CodeType='NUM' CountryType='Dispatch'>CN</Country>
                       </DeclarationHeader>
                      </Declaration>
                    <Declaration Command='DEFAULT' Version='5.13'>
                      <DeclarationHeader>
                        <Reference RefCode='MWB'>
                        </Reference>
                        <Reference RefCode='CAR'>
                          <RefText>car2</RefText>
                        </Reference>
                        <Reference RefCode='TRV'>
                          <RefText>trv2</RefText>
                        </Reference>
                       </DeclarationHeader>
                      </Declaration>
                    </DeclarationList>
                </InputDocument>";

            var refCodes = new[] { "MWB", "TRV", "CAR" };

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            var extr = new ExtractValues(doc);
            var res = extr.ExtractTextFromCodes(refCodes);

            if (res.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("no values to show!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            var print = "";
            foreach (var item in res)
            {
                print += $"{item.Key}: {item.Value}{Environment.NewLine}";
            }

            Console.WriteLine(print);
            Console.ReadKey();

        }
    }
}
