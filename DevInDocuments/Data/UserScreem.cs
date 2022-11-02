using DevInDocuments.Entities.Person;
using System.Diagnostics.Contracts;

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
                    ScreemDocumentsMenu();
                    break;
                case "-1":
                    Console.WriteLine("Bye bye and have a good rest.");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again\n");
                    MainMenu();
                    break;
            }
        }

        private static void ScreemDocumentsMenu()
        {
            Console.WriteLine("Please, what you want to screem? Choose a option:\n" +
                               "1) Screen TaxBill\n2) Screem Contracts\n3) Screem Licenses\n4) Screen all\n5)Search one by code\n" +
                               "-1) Back to Main Menu:");

            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    UserStream.SearchOneDocument(int.Parse(Console.ReadLine()));
                    break;
                case "-1":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again\n");
                    ScreemDocumentsMenu();
                    break;
            }
        }
    }
}
