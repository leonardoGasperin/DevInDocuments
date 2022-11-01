using DevInDocuments.Data;

namespace DevInDocuments.Entities.Company
{
    internal abstract class DevInDocument
    {
        ///TODO
        /// Decide the acess nivel for atributes
        private int employeeId;
        private string documentCode;
        private DateTime systemDate;
        private DateTime lastChangeDate;
        private string establishmentName;
        private string cnpj;

        ///TODO
        ///A Constructor or Props



        public void RegisterDocument(List<DevInDocument> docsList, DevInDocument document) 
        {
            docsList.Add(document);
        }

        public virtual void ScreemDocument() 
        {
        }

        public void ScreemAllDocuments()
        {
            foreach (DevInDocument document in GeneralData.documentsList)
            {

                document.ScreemDocument();
            }
        }

        public void ChangeItensDocument() { }

        public void ChangeDocumentStatus(DocumentStatus status) { }
    }
}
