using DevInDocuments.Data;
using DevInDocuments.Entities.Person;
using System.Xml.Linq;

namespace DevInDocuments.Features
{
    internal class ScreemMessage
    {

        public static void Welcome()
        {
            Console.WriteLine($"Welcome Employee: {GeneralData._employee.Name} to DevInDocuments!\n");
            UserScreem.MainMenu();
        }


        internal static void RedAlert(int alertCode)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine("Invalid option, please try again");
                    break;
                case 1:
                    Console.WriteLine("tipe anything to cancel");
                    break;
            }
            Console.ResetColor();
        }

        public static void MenuConsole(MenuType type)
        {
            switch (type)
            {
                case MenuType.Main:
                    Console.WriteLine("Please, what you want to do? Choose a option:\n" +
                               "1) Register document\n2) Edit document itens\n3) Edit document status\n4) Screem document\n" +
                               "0) Exit:");
                    break;
                case MenuType.Register:
                    Console.WriteLine("What type of Document you want to register? Choose a option:\n" +
                   "1) Tax Invoice\n2) Contracts\n3) Licenses\n0) Back to Main Menu:");
                    break;
                case MenuType.ScremmDoc:
                    Console.WriteLine("Please, what you want to screem? Choose a option:\n" +
                               "1) Screen TaxBill\n2) Screem Contracts\n3) Screem Licenses\n4) By document status\n5) Screen all\n6)Search one by code\n" +
                               "0) Back to Main Menu:");
                    break;
                default:
                    break;
            }
        }

        public static void FormsMessage(int code)
        {
            switch (code)
            {
                case 0:
                    Console.WriteLine("Enter with establishment name:");
                    break;
                case 1:
                    Console.WriteLine("Enter with CNPJ:");
                    break;
                case 2:
                    Console.WriteLine("Enter with total value price:");
                    break;
                case 3:
                    Console.WriteLine("Enter with selled product name:");
                    break;
                case 4:
                    Console.WriteLine("Enter with tax type:");
                    break;
                case 5:
                    Console.WriteLine("Enter with total tax value percentage:");
                    break;
                case 6:
                    Console.WriteLine("Enter with the goals:");
                    break;
                case 7:
                    Console.WriteLine("Enter with witnesses names:\nwitnesses 1 names:");
                    break;
                case 8:
                    Console.WriteLine("witnesses 2 names:");
                    break;
                case 9:
                    Console.WriteLine("Enter with an expiration date:\nEnter with year:");
                    break;
                case 10:
                    Console.WriteLine("Enter with month:");
                    break;
                case 11:
                    Console.WriteLine("Enter with date:");
                    break;
                case 12:
                    Console.WriteLine("Enter with the adress:");
                    break;
                case 13:
                    Console.WriteLine("Enter with the operation:");
                    break;
                case 14:
                    Console.WriteLine("Enter with Status type:");
                    break;
                case 15:
                    Console.WriteLine("Enter with Document code:");
                    break;
                default:
                    break;
            }
        }

        internal static void ClearRedAlert(int alertCode)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine("The Document recivie some value with invalid format.\nOperation canceled");
                    break;
                case 1:
                    Console.WriteLine("The Document not be found\n");
                    break;
            }
            Console.ResetColor();
        }

        internal static void YellowAlert(int alertCode)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine("Check if document is valid to confirm:\n" +
                                      "1) Save");
                    break;
                case 1:
                    Console.WriteLine("0) ICMS\n1) IPI\n2) IOF\n3) Other");
                    break;
                case 2:
                    Console.WriteLine("0) Industry\n1) Agricultural\n2) Metallurgical\n3) Technological\n 4) Others");
                    break;
                case 3:
                    Console.WriteLine("0) Active\n1) Processing\n2) Suspended");
                    break;
            }
            Console.ResetColor();
        }

        internal static void ClearGreenAlert(int alertCode)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine("Document Found!\n");
                    break;
            }
            Console.ResetColor();
        }

        internal static void GreenAlert(int alertCode)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (alertCode)
            {
                case 0:
                    Console.WriteLine($"We have {GeneralData.documentsList.Count} Documents in our Bank System");
                    break;
                case 1:
                    Console.WriteLine("Document Found!\n");
                    break;
                case 2:
                    Console.WriteLine($"\nBye bye {GeneralData._employee.Name} and have a good rest.");
                    break;
            }
            Console.ResetColor();
        }
    }
}
