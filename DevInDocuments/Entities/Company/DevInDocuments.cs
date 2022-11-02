using DevInDocuments.Data;

namespace DevInDocuments.Entities.Company
{
    internal abstract class DevInDocument
    {
        ///TODO
        /// Decide the acess nivel for atributes
        private int employeeId;
        private int documentCode;
        private DateTime systemDate;
        private string lastChangeDate;
        private string establishmentName;
        private string cnpj;

        public int DocumentCode { get { return documentCode; } }

        public DevInDocument(int employeeId, DateTime systemDate, string establishmentName, string cnpj)
        {
            this.employeeId = employeeId;
            this.documentCode = this.GetHashCode();
            this.systemDate = systemDate;
            this.establishmentName = establishmentName;
            this.cnpj = cnpj;
        }

        public DevInDocument() { }

        public void RegisterDocument(List<DevInDocument> docsList, DevInDocument document) 
        {
            docsList.Add(document);
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
                              $"||CNPJ: {this.cnpj}");
        }

        public void ChangeItensDocument() { }

        public void ChangeDocumentStatus(DocumentStatus status) { }
    }
}
