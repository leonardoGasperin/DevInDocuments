using DevInDocuments.Entities.Company;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal class UserScreem
    {
        private static string InputStream()
        {
            string userStream = Console.ReadLine();
            Console.Clear();
            return userStream;
        }

        public static void MainMenu()
        {
            ScreemMessage.GreenAlert(0);
            ScreemMessage.MenuConsole(MenuType.Main);

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
                    ScreemMessage.MenuConsole(MenuType.Exit);
                    break;
                default:
                    ScreemMessage.RedAlert(0);
                    MainMenu();
                    break;
            }
        }

        public static void RegisteringDocMenu()
        {
            ScreemMessage.MenuConsole(MenuType.Register);

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
            ScreemMessage.MenuConsole(MenuType.ScremmDoc);

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
                    GeneralData.SearchByStatus(UserStream.ChooseStatus());
                    break;
                case "5":
                    new Contracts().ScreemAllDocuments();
                    break;
                case "6":
                    try
                    {
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
    }
}
