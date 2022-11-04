using DevInDocuments.Data;
using DevInDocuments.Features;

namespace DevInDocuments.Entities.Company
{
    internal class FuntionalitiesLicenses : DevInDocument
    {
        private string adress;
        private Operation operationArea;

        public FuntionalitiesLicenses(int employeeId, string establishmentName, string cnpj,
                                      string adress, Operation operationArea) : 
                                      base(employeeId, establishmentName, cnpj)
        {
            this.adress = adress;
            this.operationArea = operationArea;
        }

        public FuntionalitiesLicenses() { }

        public override void ChangeItensDocument(FuntionalitiesLicenses licenseEditValues)
        {
            base.ChangeItensDocument(licenseEditValues);
            this.adress = licenseEditValues.adress == "" ? this.adress : licenseEditValues.adress;
            this.operationArea = licenseEditValues.operationArea;
        }

        public override void ScreamAllDocumentType()
        {
            foreach (var document in GeneralData.documentsList)
            {
                if(document is FuntionalitiesLicenses)
                    document.ScreamDocument();
            }
        }

        public override void ScreamDocument()
        {
            base.ScreamDocument();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("||--------------------------------Licenses---------------------------------\n" +
                              $"||Adress: {this.adress}\n" +
                              $"||operation Area: {this.operationArea}\n" +
                              "||#########################################################################\n");
            Console.ResetColor();
        }
    }
}
