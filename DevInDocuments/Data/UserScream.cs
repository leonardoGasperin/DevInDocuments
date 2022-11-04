using DevInDocuments.Entities.Company;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal class UserScream
    {
        private static string InputStream()
        {
            string userStream = Console.ReadLine();
            Console.Clear();
            return userStream;
        }

        public static void MainMenu()
        {
            ScreamMessage.GreenAlert(0);
            ScreamMessage.MenuConsole(MenuType.Main);

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
                    ScreamDocMenu();
                    break;
                case "0":
                    ScreamMessage.MenuConsole(MenuType.Exit);
                    break;
                default:
                    ScreamMessage.RedAlert(0);
                    MainMenu();
                    break;
            }
        }

        public static void RegisteringDocMenu()
        {
            ScreamMessage.MenuConsole(MenuType.Register);

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
                    ScreamMessage.RedAlert(0);
                    RegisteringDocMenu();
                    break;
            }
            MainMenu();
        }

        public static void ScreamDocMenu()
        {
            ScreamMessage.MenuConsole(MenuType.ScremmDoc);

            switch (InputStream())
            {
                case "1":
                    new TaxInvoice().ScreamAllDocumentType();
                    break;
                case "2":
                    new Contracts().ScreamAllDocumentType();
                    break;
                case "3":
                    new FuntionalitiesLicenses().ScreamAllDocumentType();
                    break;
                case "4":
                    GeneralData.SearchByStatus(UserStream.ChooseStatus());
                    break;
                case "5":
                    new Contracts().ScreamAllDocuments();
                    break;
                case "6":
                    try
                    {
                        int docCode = UserStream.ReceveidDocCode();
                        GeneralData.SearchOneDocument(docCode).ScreamDocument();
                    }
                    catch
                    {
                        ScreamMessage.ClearRedAlert(0);
                    }
                    break;
                case "0":
                    break;
                default:
                    ScreamMessage.RedAlert(0);
                    ScreamDocMenu();
                    break;
            }
            MainMenu();
        }
    }
}
