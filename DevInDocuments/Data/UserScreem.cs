using DevInDocuments.Entities.Company;
using DevInDocuments.Entities.Person;

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
            Console.Clear();
            Console.WriteLine("Please, what you want to do? Choose a option:\n" +
                               "1) Register document\n2) Edit document\n3) Screem document\n" +
                               "-1) Exit:");

            switch (Console.ReadLine())
            {
                case "1":
                    UserStream.RegisteringDocument();
                    break;
                case "2":
                    UserStream.EditingDocument();
                    break;
                case "3":
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid option, please try again\n");
                    Console.ResetColor();
                    MainMenu();
                    break;
            }
        }

        public static void ScreemDocMenu()
        {
            Console.WriteLine("Please, what you want to screem? Choose a option:\n" +
                               "1) Screen TaxBill\n2) Screem Contracts\n3) Screem Licenses\n4) Screen all\n5)Search one by code\n" +
                               "-1) Back to Main Menu:");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    new TaxInvoice().ScreemAllDocumentType();
                    ScreemDocMenu();
                    break;
                case "2":
                    Console.Clear();
                    new Contracts().ScreemAllDocumentType();
                    ScreemDocMenu();
                    break;
                case "3":
                    Console.Clear();
                    new FuntionalitiesLicenses().ScreemAllDocumentType();
                    ScreemDocMenu();
                    break;
                case "4":
                    Console.Clear();
                    new Contracts().ScreemAllDocuments();
                    ScreemDocMenu();
                    break;
                case "5":
                    int docCode = UserStream.RecivieDocCode();
                    UserStream.SearchOneDocument(docCode).ScreemDocument();
                    ScreemDocMenu();
                    break;
                case "-1":
                    MainMenu();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option, please try again\n");
                    Console.ResetColor();
                    ScreemDocMenu();
                    break;
            }
            ///TODO Exception to be a loop
        }

        public static void EditingDocMenu()
        {

        }
    }
}
