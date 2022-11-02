using DevInDocuments.Data;

namespace DevInDocuments.Entities.Company
{
    internal class TaxInvoice : DevInDocument
    {
        ///TODO
        /// Decide the acess nivel for atributes

        private decimal totalValue;
        private string SelledProductName;
        private TaxType taxType;
        private float totalTaxValue;

        public TaxInvoice(int employeeId, DateTime systemDate, string establishmentName, string cnpj,
                          decimal totalValue, string SelledProductName, TaxType taxType, float totalTaxValue) : 
                          base(employeeId, systemDate, establishmentName, cnpj)
        {
            this.totalValue = totalValue;
            this.SelledProductName = SelledProductName;
            this.taxType = taxType;
            this.totalTaxValue = totalTaxValue;
        }

        public TaxInvoice() { }

        public override void ScreemAllDocumentType()
        {
            foreach (var document in GeneralData.documentsList)
            {
                if(document is TaxInvoice)
                    document.ScreemDocument();
            }
        }

        public override void ScreemDocument()
        {
            base.ScreemDocument();

            Console.WriteLine("||###############################TaxInvoice################################\n" +
                              $"||Total value: {this.totalValue:C}\n" +
                              $"||Name of selled product: {this.SelledProductName}\n" +
                              $"||Tax type: {this.taxType}\n" +
                              $"||Total tax value: {this.totalTaxValue}%\n" +
                              "||#########################################################################\n" +
                              "||-------------------------------------------------------------------------\n");
        }
    }
}
