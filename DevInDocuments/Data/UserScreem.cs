namespace DevInDocuments.Data
{
    internal static class UserScreem
    {
        public static void Welcome(string name)
        {
            Console.WriteLine($"Welcome Employee: {name} to DevInDocuments!\n");
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
                               "1) Screen TaxBill\n2) Screem Contracts\n3) Screem Licenses\n4) Screen all" +
                               "-1) Back to Main Menu:");

            switch (Console.ReadLine())
            {
                case "1":
                    ScreemTaxBillMenu();
                    break;
                case "2":
                    ScreemContractsMenu();
                    break;
                case "3":
                    ScreemLicensesMenu();
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

        private static void ScreemContractsMenu()
        {
            Console.WriteLine("Please, what you want to screem? Choose a option:\n" +
                               "1) Shearch one to Screen\n2) Screem all Contracts" +
                               "-1) Back to Main Menu:");

            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "-1":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again\n");
                    ScreemContractsMenu();
                    break;
            }
        }

        private static void ScreemTaxBillMenu()
        {
            Console.WriteLine("Please, what you want to screem? Choose a option:\n" +
                               "1) Shearch one to Screen\n2) Screem all TaxBills" +
                               "-1) Back to Main Menu:");

            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "-1":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again\n");
                    ScreemTaxBillMenu();
                    break;
            }
        }

        private static void ScreemLicensesMenu()
        {
            Console.WriteLine("Please, what you want to screem? Choose a option:\n" +
                               "1) Shearch one to Screen\n2) Screem all Licenses" +
                               "-1) Back to Main Menu:");

            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "-1":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again\n");
                    ScreemLicensesMenu();
                    break;
            }
        }
    }
}
