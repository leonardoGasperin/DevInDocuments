using DevInDocuments.Data;

namespace DevInDocuments.Entities.Company
{
    internal class Contracts : DevInDocument
    {
        ///TODO
        /// Decide the acess nivel for atributes

        private string goals;
        private string[] witnessName;
        private DateTime expirationDate;

        public Contracts(int employeeId, DateTime systemDate, string establishmentName, string cnpj,
                         string goals, string[] witnessName, DateTime expirationDate) : 
                         base(employeeId, systemDate, establishmentName, cnpj)
        {
            this.goals = goals;
            this.witnessName = witnessName;
            this.expirationDate = expirationDate;
        }

        public Contracts() { }

        public override void ScreemAllSpecificDocuments()
        {
            foreach (var contract in GeneralData.documentsList)
            {
                if (contract is Contracts)
                    contract.ScreemDocument();
            }
        }

        public override void ScreemDocument()
        {
            base.ScreemDocument();

            Console.WriteLine("||################################Contracts################################\n"+
                              $"||Goals: {this.goals}\n" +
                              $"||Witness 1 name: {this.witnessName[0]}\n" +
                              $"||Witness 2 name: {this.witnessName[1]}\n" +
                              $"||Date for expiration: {this.expirationDate}\n" +
                              "||#########################################################################\n" +
                              "||-------------------------------------------------------------------------\n");
        }
    }
}
