namespace DevInDocuments.Entities.Company
{
    internal class Contracts : DevInDocument
    {
        ///TODO
        /// Decide the acess nivel for atributes

        private string goals;
        private string[] witnessName;
        private DateTime expirationDate;

        public Contracts(string goals, string[] witnessName, DateTime expirationDate)
        {
            this.goals = goals;
            this.witnessName = witnessName;
            this.expirationDate = expirationDate;
        }

        public override void ScreemDocument()
        {
            Console.WriteLine(this.goals);
            Console.WriteLine(this.witnessName[0]);
            Console.WriteLine(this.witnessName[1]);
            Console.WriteLine(this.expirationDate);
            Console.WriteLine("\n");
        }

        ///TODO
        ///A Constructor or Props
    }
}
