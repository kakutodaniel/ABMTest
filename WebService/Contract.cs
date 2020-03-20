namespace WebService
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class InputDocument
    {

        private InputDocumentDeclaration[] declarationListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Declaration", IsNullable = false)]
        public InputDocumentDeclaration[] DeclarationList
        {
            get
            {
                return this.declarationListField;
            }
            set
            {
                this.declarationListField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InputDocumentDeclaration
    {

        private InputDocumentDeclarationDeclarationHeader declarationHeaderField;

        private string commandField;

        private decimal versionField;

        /// <remarks/>
        public InputDocumentDeclarationDeclarationHeader DeclarationHeader
        {
            get
            {
                return this.declarationHeaderField;
            }
            set
            {
                this.declarationHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Command
        {
            get
            {
                return this.commandField;
            }
            set
            {
                this.commandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InputDocumentDeclarationDeclarationHeader
    {

        private string jurisdictionField;

        private string cWProcedureField;

        private string declarationDestinationField;

        private string documentRefField;

        private string siteIDField;

        private string accountCodeField;

        /// <remarks/>
        public string Jurisdiction
        {
            get
            {
                return this.jurisdictionField;
            }
            set
            {
                this.jurisdictionField = value;
            }
        }

        /// <remarks/>
        public string CWProcedure
        {
            get
            {
                return this.cWProcedureField;
            }
            set
            {
                this.cWProcedureField = value;
            }
        }

        /// <remarks/>
        public string DeclarationDestination
        {
            get
            {
                return this.declarationDestinationField;
            }
            set
            {
                this.declarationDestinationField = value;
            }
        }

        /// <remarks/>
        public string DocumentRef
        {
            get
            {
                return this.documentRefField;
            }
            set
            {
                this.documentRefField = value;
            }
        }

        /// <remarks/>
        public string SiteID
        {
            get
            {
                return this.siteIDField;
            }
            set
            {
                this.siteIDField = value;
            }
        }

        /// <remarks/>
        public string AccountCode
        {
            get
            {
                return this.accountCodeField;
            }
            set
            {
                this.accountCodeField = value;
            }
        }
    }


}