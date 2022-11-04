using DevInDocuments.Data;
using DevInDocuments.Features;

namespace DevInDocuments.Entities.Company
{
    internal abstract class DevInDocument
    {
        protected int employeeId;
        protected int documentCode;
        private readonly DateTime systemDate;
        protected string lastChangeDate;
        protected string establishmentName;
        protected string cnpj;
        protected DocumentStatus documentStatus;

        public int DocumentCode { get { return documentCode; } }
        public DocumentStatus DocumentStatus { get { return documentStatus; } }

        public DevInDocument(int employeeId, string establishmentName, string cnpj)
        {
            this.employeeId = employeeId;
            this.documentCode = this.GetHashCode();
            this.systemDate = DateTime.Now;
            this.establishmentName = establishmentName;
            this.cnpj = cnpj;
            this.documentStatus = DocumentStatus.Processing;
        }

        public DevInDocument() { }

        public void RegisterDocument(List<DevInDocument> docsList, DevInDocument document) 
        {
            docsList.Add(document);
        }

        public void ChangeItensDocument(DevInDocument docEditValues)
        {
            this.employeeId = docEditValues.employeeId;
            this.establishmentName = docEditValues.establishmentName;
            this.cnpj = docEditValues.cnpj;
            this.lastChangeDate = DateTime.Now.ToString();
        }

        public virtual void ChangeItensDocument(TaxInvoice taxEditValues)
        {
            ChangeItensDocument(taxEditValues as DevInDocument);
        }

        public virtual void ChangeItensDocument(Contracts contractsEditValues)
        {
            ChangeItensDocument(contractsEditValues as DevInDocument);
        }

        public virtual void ChangeItensDocument(FuntionalitiesLicenses licenseEditValues)
        {
            ChangeItensDocument(licenseEditValues as DevInDocument);
        }

        public void ChangeDocumentStatus(DocumentStatus status)
        {
            this.lastChangeDate = DateTime.Now.ToString();
            this.documentStatus = status;
        }

        public void ScreamAllDocuments()
        {
            foreach (DevInDocument document in GeneralData.documentsList)
            {
                document.ScreamDocument();
            }
            Console.ResetColor();
        }

        public virtual void ScreamAllDocumentType() 
        {
        }

        public virtual void ScreamDocument()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("||################################DOCUMENT#################################\n" +
                              $"||Employee ID: {this.employeeId}\n" +
                              $"||Document Code: [{this.documentCode}]\n" +
                              $"||System Date: {systemDate}\n" +
                              $"||Date of Last Changes of Document: {this.lastChangeDate}\n" +
                              $"||Name of establishment: {this.establishmentName}\n" +
                              $"||CNPJ: {this.cnpj}\n" +
                              $"||Document Status: {this.documentStatus}");
        }
    }
}
