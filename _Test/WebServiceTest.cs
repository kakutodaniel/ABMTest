﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace _Test
{
    [TestClass]
    public class WebServiceTest
    {
        readonly string _payload = @"
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
                          </DeclarationHeader>
                        </Declaration>
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
            var el = LoadXml(payload);

            var service = new ws.WebServiceDocSoapClient();
            var result = service.CheckXML(el);

            Assert.IsNotNull(result);
            Assert.IsTrue(result == "0");
        }

        [TestMethod]
        public void Test_Command_Different_Default()
        {
            var payload = string.Format(_payload, "DEFAULT999", "DUB");
            var el = LoadXml(payload);

            var service = new ws.WebServiceDocSoapClient();
            var result = service.CheckXML(el);

            Assert.IsNotNull(result);
            Assert.IsTrue(result == "-1");
        }

        [TestMethod]
        public void Test_Site_Different_Dub()
        {
            var payload = string.Format(_payload, "DEFAULT", "DUB999");
            var el = LoadXml(payload);

            var service = new ws.WebServiceDocSoapClient();
            var result = service.CheckXML(el);

            Assert.IsNotNull(result);
            Assert.IsTrue(result == "-2");
        }

        private XmlDocument LoadXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            return doc;
        }

    }
}
