//logo de inicio aqui sera somente Sheidi Teste
using DevInDocuments.Data;
using DevInDocuments.Entities.Company;
using DevInDocuments.Entities.Person;
using DevInDocuments.Features;

GeneralData.InitializeList();

var _employee = new Employee("Zezé da Malta", "Jaridm Antonia", "Castelinho de Queijo",
                             new DateTime(1970, 1, 1), new DateTime(2021,03,27));

/*
string[] witness = { "Jão", "Aldineya" };

var con2 = new Contracts(_employee.Id, "Castelinho de Queijo", "39.921.922/0001-47", 
                         "Development of light software", witness, new DateTime(1997, 1, 1));

var con = new Contracts(_employee.Id, "Maqui Donauldes", "37.987.512/0001-35",
                        "Work Hard", witness, DateTime.Now);

var license = new FuntionalitiesLicenses(_employee.Id, "Technologic Institute of University of Helsinki", "00.789.734/0001-08",
                                         "Av. Da Malta", Operation.Technology);

var tax = new TaxInvoice(_employee.Id, "Castelinho de Queijo", "39.921.922/0001-47", 1936.51m, "PC", TaxType.IPI, 0.25f);


con.RegisterDocument(GeneralData.documentsList, con);
con2.RegisterDocument(GeneralData.documentsList, con2);
license.RegisterDocument(GeneralData.documentsList, license);
tax.RegisterDocument(GeneralData.documentsList, tax);
*/
UserScreem.Welcome(_employee);
