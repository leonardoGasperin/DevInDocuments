using DevInDocuments.Data;
using DevInDocuments.Features;

namespace DevInDocuments.Entities.Company
{
    internal class TaxInvoice : DevInDocument
    {
        private decimal totalValue;
        private string SelledProductName;
        private TaxType taxType;
        private decimal totalTaxValue;

        public TaxInvoice(int employeeId, string establishmentName, string cnpj,
                          decimal totalValue, string SelledProductName, TaxType taxType, decimal totalTaxValue) : 
                          base(employeeId, establishmentName, cnpj)
        {
            this.totalValue = totalValue;
            this.SelledProductName = SelledProductName;
            this.taxType = taxType;
            this.totalTaxValue = totalTaxValue;
        }

        public TaxInvoice() { }

        public override void ChangeItensDocument(TaxInvoice taxEditValues)
        {
            base.ChangeItensDocument(taxEditValues);
            this.totalValue = taxEditValues.totalValue;
            this.SelledProductName = taxEditValues.SelledProductName;
            this.taxType = taxEditValues.taxType;
            this.totalTaxValue = taxEditValues.totalTaxValue;
        }

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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("||--------------------------------TaxInvoice--------------------------------\n" +
                              $"||Total value: {this.totalValue:C}\n" +
                              $"||Name of selled product: {this.SelledProductName}\n" +
                              $"||Tax type: {this.taxType}\n" +
                              $"||Total tax value: {this.totalTaxValue}%\n" +
                              "||#########################################################################\n");
            Console.ResetColor();
        }
    }
}
