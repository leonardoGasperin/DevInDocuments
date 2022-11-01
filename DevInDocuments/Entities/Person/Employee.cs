namespace DevInDocuments.Entities.Person
{
    internal class Employee
    {
        private int id;
        private string name;
        private string adress;
        private string afiliation;
        private DateTime bornDate;
        private DateTime admissionDate;

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

        public void RegisterEmployee(List<Employee> employeeList, Employee employee)
        {
            employeeList.Add(employee);
        }
    }
}
