using System;
using XML.DefaultDocument;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = @"
                <InputDocument>
                  <DeclarationList>
                    <Declaration Command='DEFAULT' Version='5.13'/>
                      <DeclarationHeader>
                        <Jurisdiction>IE</Jurisdiction>
                        <CWProcedure>IMPORT</CWProcedure>
                        <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
                        <DocumentRef>71Q0019681</DocumentRef>
                        <SiteID>DUB</SiteID>
                        <AccountCode>G0779837</AccountCode>
                        <Reference RefCode='MWB'>
                          <RefText>586133622</RefText>
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
                    </DeclarationList>
                </InputDocument>";

            var refCodes = new[] { "MWB", "TRV", "CAR" };
            var extr = new ExtractValues(xml);
            var res = extr.ExtractTextFromCodes(refCodes);

            if (!res.Success)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(res.ErrorMessage);
            }
            else
            {
                Console.WriteLine(res.Response);
            }

            Console.ReadKey();

        }
    }
}
