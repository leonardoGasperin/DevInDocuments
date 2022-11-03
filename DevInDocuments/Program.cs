using DevInDocuments.Data;
using DevInDocuments.Entities.Person;

GeneralData.InitializeList();

var _employee = new Employee("Zezé da Mata", "Jaridm Antonia", "Castelinho de Queijo",
                             new DateTime(1970, 1, 1), new DateTime(2021,03,27));
UserScreem.Welcome(_employee);
