namespace DevInDocuments.Entities.Person
{
    internal class Employee
    {
        private readonly int id;
        private readonly string name;
        private readonly string adress;
        private readonly string afiliation;
        private readonly DateTime bornDate;
        private readonly DateTime admissionDate;

        public string Name { get { return name; } }
        public int Id { get { return id; } }

        public Employee(string name, string adress, string afiliation, DateTime bornDate, DateTime admissionDate)
        {
            this.id = this.GetHashCode();
            this.name = name;
            this.adress = adress;
            this.afiliation = afiliation;
            this.bornDate = bornDate;
            this.admissionDate = admissionDate;
        }
    }
}
