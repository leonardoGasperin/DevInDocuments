//logo de inicio aqui sera somente Sheidi Teste
using DevInDocuments.Data;
using DevInDocuments.Entities.Company;
using DevInDocuments.Entities.Person;

GeneralData.InitializeList();

var _employee = new Employee("Zezé da Malta", "Jaridm Antonia", "Castelinho de Queijo", new DateTime(1970, 1, 1), new DateTime(2021,03,27));

UserScreem.Welcome(_employee.Name);

/*
Console.WriteLine("Hello DevInDocuments\n");

string[] witness = { "Jão", "Aldineya" };

var con2 = new Contracts("222 111", witness, new DateTime(1970, 1, 1));

var con = new Contracts("Work Hard", witness, DateTime.Now);


con.RegisterDocument(GeneralData.documentsList, con);
con2.RegisterDocument(GeneralData.documentsList, con2);
con2.ScreemAllDocuments();*/
