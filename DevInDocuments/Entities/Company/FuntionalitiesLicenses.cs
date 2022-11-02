using DevInDocuments.Data;

namespace DevInDocuments.Entities.Company
{
    internal class FuntionalitiesLicenses : DevInDocument
    {
        ///TODO
        /// Decide the acess nivel for atributes

        private string adress;
        private Operation operationArea;

        public FuntionalitiesLicenses(int employeeId, DateTime systemDate, string establishmentName, string cnpj,
                                      string adress, Operation operationArea) : 
                                      base(employeeId, systemDate, establishmentName, cnpj)
        {
            this.adress = adress;
            this.operationArea = operationArea;
        }

        public override void ScreemAllSpecificDocuments()
        {
            foreach (var document in GeneralData.documentsList)
            {
                if(document is FuntionalitiesLicenses)
                    document.ScreemDocument();
            }
        }

        public override void ScreemDocument()
        {
            base.ScreemDocument();

            Console.WriteLine("||################################Licenses#################################\n" +
                              $"||Adress: {this.adress}\n" +
                              $"||operation Area: {this.operationArea}\n" +
                              "||#########################################################################\n" +
                              "||-------------------------------------------------------------------------\n");
        }
    }
}
