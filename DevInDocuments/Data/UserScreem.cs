using DevInDocuments.Entities.Company;
using DevInDocuments.Entities.Person;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal class UserScreem
    {
        private static Employee _employee;

        public static void Welcome(Employee values)
        {
            _employee = values;
            Console.WriteLine($"Welcome Employee: {_employee.Name} to DevInDocuments!\n");
            MainMenu();
        }

        private static string InputStream()
        {
            string userStream = Console.ReadLine();
            Console.Clear();
            return userStream;
        }

        public static void MainMenu()
        {
            ScreemMessage.GreenAlert(0);

            Console.WriteLine("Please, what you want to do? Choose a option:\n" +
                               "1) Register document\n2) Edit document itens\n3) Edit document status\n4) Screem document\n" +
                               "0) Exit:");

            switch (InputStream())
            {
                case "1":
                    RegisteringDocMenu();
                    break;
                case "2":
                    UserStream.EditingDocument();
                    break;
                case "3":
                    UserStream.EditingDocumentStatus();
                    break;
                case "4":
                    ScreemDocMenu();
                    break;
                case "0":
                    ScreemMessage.GreenAlert(1, _employee.Name);
                    break;
                default:
                    ScreemMessage.RedAlert(0);
                    MainMenu();
                    break;
            }
        }

        public static void RegisteringDocMenu()
        {
            Console.WriteLine("What type of Document you want to register? Choose a option:\n" +
                               "1) Tax Invoice\n2) Contracts\n3) Licenses\n0) Back to Main Menu:");

            switch (InputStream())
            {
                case "1":
                    UserStream.RegisteringDocument(new TaxInvoice());
                    break;
                case "2":
                    UserStream.RegisteringDocument(new Contracts());
                    break;
                case "3":
                    UserStream.RegisteringDocument(new FuntionalitiesLicenses());
                    break;
                case "0":
                    break;
                default:
                    ScreemMessage.RedAlert(0);
                    RegisteringDocMenu();
                    break;
            }
            MainMenu();
        }

        public static void ScreemDocMenu()
        {
            Console.WriteLine("Please, what you want to screem? Choose a option:\n" +
                               "1) Screen TaxBill\n2) Screem Contracts\n3) Screem Licenses\n4) By document status\n5) Screen all\n6)Search one by code\n" +
                               "0) Back to Main Menu:");

            switch (InputStream())
            {
                case "1":
                    new TaxInvoice().ScreemAllDocumentType();
                    break;
                case "2":
                    new Contracts().ScreemAllDocumentType();
                    break;
                case "3":
                    new FuntionalitiesLicenses().ScreemAllDocumentType();
                    break;
                case "4":
                    GeneralData.SearchByStatus(ChooseStatus());
                    break;
                case "5":
                    new Contracts().ScreemAllDocuments();
                    break;
                case "6":
                    try
                    {
                        Console.Clear();
                        int docCode = UserStream.RecivieDocCode();
                        GeneralData.SearchOneDocument(docCode).ScreemDocument();
                    }
                    catch
                    {
                        ScreemMessage.ClearRedAlert(0);
                    }
                    break;
                case "0":
                    break;
                default:
                    ScreemMessage.RedAlert(0);
                    ScreemDocMenu();
                    break;
            }
            MainMenu();
        }

        public static TaxInvoice RecivieingTaxValues()
        {
            Console.WriteLine("Enter with establishment name:");
            string newEstablishmentName = Console.ReadLine();
            Console.WriteLine("Enter with CNPJ:");
            string newCnpj = Console.ReadLine();
            Console.WriteLine("Enter with total value price:");
            string newTotalValue = Console.ReadLine();
            Console.WriteLine("Enter with selled product name:");
            string newSelledProductName = Console.ReadLine();
            Console.WriteLine("Enter with tax type:");
            ScreemMessage.YellowAlert(1);
            TaxType newTaxType = UserStream.ChoosenTaxType(Console.ReadLine());
            Console.WriteLine("Enter with total tax value percentage:");
            string newTotalTaxValue = Console.ReadLine();

            return new TaxInvoice(_employee.Id, newEstablishmentName, newCnpj, decimal.Parse(newTotalValue),
                                  newSelledProductName, newTaxType, decimal.Parse(newTotalTaxValue));
        }

        public static Contracts RecivieingContractsValues()
        {
            Console.WriteLine("Enter with establishment name:");
            string newEstablishmentName = Console.ReadLine();
            Console.WriteLine("Enter with CNPJ:");
            string newCnpj = Console.ReadLine();
            Console.WriteLine("Enter with the goals:");
            string newGoals = Console.ReadLine();
            Console.WriteLine("Enter with witnesses names:");
            string[] newWitnessName = { "", "" };
            Console.WriteLine("witnesses 1 names:");
            newWitnessName[0] = Console.ReadLine();
            Console.WriteLine("witnesses 2 names:");
            newWitnessName[1] = Console.ReadLine();
            Console.WriteLine("Enter with an expiration date:");
            Console.WriteLine("Enter with year:");
            string year = Console.ReadLine();
            Console.WriteLine("Enter with month:");
            string month = Console.ReadLine();
            Console.WriteLine("Enter with date:");
            string day = Console.ReadLine();

            return new Contracts(_employee.Id, newEstablishmentName, newCnpj, newGoals, newWitnessName, 
                                 new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)));
        }

        public static FuntionalitiesLicenses RecivieingLicensesValues()
        {
            Console.WriteLine("Enter with new establishment name:");
            string newEstablishmentName = Console.ReadLine();
            Console.WriteLine("Enter with new CNPJ:");
            string newCnpj = Console.ReadLine();
            Console.WriteLine("Enter with the adress:");
            string newAdress = Console.ReadLine();
            Console.WriteLine("Enter with the operation:");
            ScreemMessage.YellowAlert(2);
            Operation newOperation = UserStream.ChoosenOperationType(Console.ReadLine());

            return new FuntionalitiesLicenses(_employee.Id, newEstablishmentName, newCnpj, newAdress, newOperation);
        }

        public static DocumentStatus ChooseStatus()
        {
            Console.WriteLine("Enter with Status type:");
            ScreemMessage.YellowAlert(3);
            DocumentStatus status = UserStream.ChoosenStatusType(Console.ReadLine());

            return status;
        }
    }
}
