namespace DevInDocuments.Entities.Person
{
    internal class Documents : Employee
    {
        ///TODO
        /// Decide the acess nivel for atributes

        private string documentName;
        private DateTime systemDate;
        private DateTime lastChangeDate;
        private string establishmentName;
        private string cnpj;

        ///TODO
        ///A Constructor or Props
        
        public void RegisterDocument() { }

        public void ScreemDocuments() { }

        public void ChangeItensDocument() { }

        public DocumentStatus ChangeDocumentStatus() { return DocumentStatus.Active; }
    }
}
