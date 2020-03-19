using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _Test
{
    [TestClass]
    public class WebServiceTest
    {
        readonly string _payload = @"
                   <InputDocument>
                      <DeclarationList>
                        <Declaration Command='{0}' Version='5.13'>
                          <DeclarationHeader>
                            <Jurisdiction>IE</Jurisdiction>
                            <CWProcedure>IMPORT</CWProcedure>
                            <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
                            <DocumentRef>71Q0019681</DocumentRef>
                            <SiteID>{1}</SiteID>
                            <AccountCode>G0779837</AccountCode>
                          </DeclarationHeader>
                        </Declaration>
                      </DeclarationList>
                    </InputDocument>
                ";


        [TestMethod]
        public void Test_Success()
        {
            var payload = string.Format(_payload, "DEFAULT", "DUB");

            var service = new ws.WebServiceDocSoapClient();
            var result = service.HelloWorld(payload);

            Assert.IsNotNull(result);
            Assert.IsTrue(result == "0");
        }

        [TestMethod]
        public void Test_Command_Different_Default()
        {
            var payload = string.Format(_payload, "DEFAULT999", "DUB");

            var service = new ws.WebServiceDocSoapClient();
            var result = service.HelloWorld(payload);

            Assert.IsNotNull(result);
            Assert.IsTrue(result == "-1");
        }

        [TestMethod]
        public void Test_Site_Different_Dub()
        {
            var payload = string.Format(_payload, "DEFAULT", "DUB999");

            var service = new ws.WebServiceDocSoapClient();
            var result = service.HelloWorld(payload);

            Assert.IsNotNull(result);
            Assert.IsTrue(result == "-2");
        }

    }
}
