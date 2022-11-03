using DevInDocuments.Data;
using DevInDocuments.Features;

namespace DevInDocuments.Entities.Company
{
    internal abstract class DevInDocument
    {
        ///TODO
        /// Decide the acess nivel for atributes
        protected int employeeId;
        protected int documentCode;
        private readonly DateTime systemDate;
        protected string lastChangeDate;
        protected string establishmentName;
        protected string cnpj;
        protected DocumentStatus documentStatus;

        public int DocumentCode { get { return documentCode; } }

        public DevInDocument(int employeeId, string establishmentName, string cnpj)
        {
            this.employeeId = employeeId;
            this.documentCode = this.GetHashCode();
            this.systemDate = DateTime.Now;
            this.establishmentName = establishmentName;
            this.cnpj = cnpj;
            this.documentStatus = DocumentStatus.Active;
        }

        public DevInDocument() { }

        public void RegisterDocument(List<DevInDocument> docsList, DevInDocument document) 
        {
            docsList.Add(document);
        }

        public virtual void ChangeItensDocument(TaxInvoice taxEditValues)
        {
            this.employeeId = taxEditValues.employeeId;
            this.documentCode = taxEditValues.documentCode;
            this.establishmentName = taxEditValues.establishmentName;
            this.cnpj = taxEditValues.cnpj;
            this.lastChangeDate = DateTime.Now.ToString();
        }

        public virtual void ChangeItensDocument(Contracts contractsEditValues)
        {
            this.employeeId = contractsEditValues.employeeId;
            this.documentCode = contractsEditValues.documentCode;
            this.establishmentName = contractsEditValues.establishmentName;
            this.cnpj = contractsEditValues.cnpj;
            this.lastChangeDate = DateTime.Now.ToString();
        }

        public virtual void ChangeItensDocument(FuntionalitiesLicenses licenseEditValues)
        {
            this.employeeId = licenseEditValues.employeeId;
            this.documentCode = licenseEditValues.documentCode;
            this.establishmentName = licenseEditValues.establishmentName;
            this.cnpj = licenseEditValues.cnpj;
            this.lastChangeDate = DateTime.Now.ToString();
        }

        public void ScreemAllDocuments()
        {
            foreach (DevInDocument document in GeneralData.documentsList)
            {
                document.ScreemDocument();
            }
            Console.ResetColor();
        }

        public virtual void ScreemAllDocumentType() 
        {
        }

        public virtual void ScreemDocument()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("||################################DOCUMENT#################################\n" +
                              $"||Employee ID: {this.employeeId}\n" +
                              $"||Document Code: [{this.documentCode}]\n" +
                              $"||System Date: {systemDate}\n" +
                              $"||Date of Last Changes of Document: {this.lastChangeDate}\n" +
                              $"||Name of establishment: {this.establishmentName} \n" +
                              $"||CNPJ: {this.cnpj}\n" +
                              $"||Document Status: {this.documentStatus}");
        }

        public void ChangeDocumentStatus(DocumentStatus status) 
        {
            this.lastChangeDate = DateTime.Now.ToString();
            this.documentStatus = status;
        }
    }
}
