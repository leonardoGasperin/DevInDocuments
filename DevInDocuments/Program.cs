using DevInDocuments.Data;
using DevInDocuments.Entities.Person;
using DevInDocuments.Features;

var _employee = new Employee("Leonardo Vinicius De Gasperin", "Jaridm Porto Belo Nº3000", "EDP technologic Squad",
                             new DateTime(1992, 6, 26), new DateTime(2022,12,24));

GeneralData.InitializeMenu(_employee);
GeneralData.InitializeList();
ScreemMessage.Welcome();