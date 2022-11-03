using DevInDocuments.Entities.Company;
using DevInDocuments.Entities.Person;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal static class UserScreem
    {
        private static Employee _employee;
        public static void Welcome(Employee values)
        {
            _employee = values;
            Console.WriteLine($"Welcome Employee: {_employee.Name} to DevInDocuments!\n");
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"We have {GeneralData.documentsList.Count} Documents in our Bank System");
            Console.ResetColor();

            Console.WriteLine("Please, what you want to do? Choose a option:\n" +
                               "1) Register document\n2) Edit document itens\n3) Edit document status\n4) Screem document\n" +
                               "-1) Exit:");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    RegisteringDocMenu();
                    break;
                case "2":
                    Console.Clear();
                    UserStream.EditingDocument();
                    break;
                case "3":
                    Console.Clear();
                    UserStream.EditingDocumentStatus();
                    break;
                case "4":
                    Console.Clear();
                    ScreemDocMenu();
                    break;
                case "-1":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nBye bye and have a good rest.");
                    Console.ResetColor();
                    break;
                default:
                    Console.Clear();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid option, please try again\n");
                    Console.ResetColor();
                    MainMenu();
                    break;
            }
        }

        public static void RegisteringDocMenu()
        {
            Console.WriteLine("What type of Document you want to register? Choose a option:\n" +
                               "1) Tax Invoice\n2) Contracts\n3) Licenses\n-1) Back to Main Menu:");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    UserStream.RegisteringDocument(new TaxInvoice());
                    MainMenu();
                    break;
                case "2":
                    Console.Clear();
                    UserStream.RegisteringDocument(new Contracts());
                    MainMenu();
                    break;
                case "3":
                    Console.Clear();
                    UserStream.RegisteringDocument(new FuntionalitiesLicenses());
                    MainMenu();
                    break;
                case "-1":
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option, please try again\n");
                    Console.ResetColor();
                    RegisteringDocMenu();
                    break;
            }
        }
        
        public static void ScreemDocMenu()
        {
            Console.WriteLine("Please, what you want to screem? Choose a option:\n" +
                               "1) Screen TaxBill\n2) Screem Contracts\n3) Screem Licenses\n4) By document status\n5) Screen all\n6)Search one by code\n" +
                               "-1) Back to Main Menu:");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    new TaxInvoice().ScreemAllDocumentType();
                    MainMenu();
                    break;
                case "2":
                    Console.Clear();
                    new Contracts().ScreemAllDocumentType();
                    MainMenu();
                    break;
                case "3":
                    Console.Clear();
                    new FuntionalitiesLicenses().ScreemAllDocumentType();
                    MainMenu();
                    break;
                case "4":
                    Console.Clear();
                    GeneralData.SearchByStatus(ChooseStatus());
                    MainMenu();
                    break;
                case "5":
                    Console.Clear();
                    new Contracts().ScreemAllDocuments();
                    MainMenu();
                    break;
                case "6":
                    Console.Clear();
                    try
                    {
                        int docCode = UserStream.RecivieDocCode();
                        GeneralData.SearchOneDocument(docCode).ScreemDocument();
                    }
                    catch
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The Document not be found or code is not in valid format.\n");
                        Console.ResetColor();
                    }
                    MainMenu();
                    break;
                case "-1":
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option, please try again\n");
                    Console.ResetColor();
                    ScreemDocMenu();
                    break;
            }
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("0) ICMS\n1) IPI\n2) IOF\n3) Other");
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("0) Industry\n1) Agricultural\n2) Metallurgical\n3) Technology\n4) Other");
            Console.ResetColor();
            Operation newOperation = UserStream.ChoosenOperationType(Console.ReadLine());

            return new FuntionalitiesLicenses(_employee.Id, newEstablishmentName, newCnpj, newAdress, newOperation);
        }

        public static DocumentStatus ChooseStatus()
        {

            Console.WriteLine("Enter with Status type:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("0) Active\n1) Processing\n2) Suspended");
            Console.ResetColor();
            DocumentStatus status = UserStream.ChoosenStatusType(Console.ReadLine());

            return status;
        }
    }
}
