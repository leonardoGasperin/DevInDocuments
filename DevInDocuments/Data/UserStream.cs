using DevInDocuments.Entities.Company;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal static class UserStream
    {
        internal static int RecivieDocCode()
        {
            Console.WriteLine("Enter with Document code:");
            _ = int.TryParse(Console.ReadLine(), out var code);
            return code;
        }

        public static DevInDocument SearchOneDocument(int code)
        {
            foreach (var doc in GeneralData.documentsList)
            {
                if (doc.DocumentCode == code)
                {
                    return doc;
                }
            }

            return DocNotFound();
        }

        public static DevInDocument DocNotFound()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Document not be found or code must be only interger.\nTry again");
            Console.ResetColor();
            return SearchOneDocument(RecivieDocCode());
        }

        public static void RegisteringDocument(DevInDocument docCreation)
        {
            switch (docCreation)
            {
                case TaxInvoice:
                    docCreation = UserScreem.RecivieingTaxValues();
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                    Console.Clear();
                    docCreation.ScreemDocument();
                    break;
                case Contracts:
                    docCreation = UserScreem.RecivieingTaxValues();
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                    Console.Clear();
                    docCreation.ScreemDocument();
                    break;
                case FuntionalitiesLicenses:
                    docCreation = UserScreem.RecivieingTaxValues();
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                    Console.Clear();
                    docCreation.ScreemDocument();
                    break;
            }
        }

        public static void EditingDocument()
        {
            var docEdit = SearchOneDocument(RecivieDocCode());

            switch (docEdit)
            {
                case TaxInvoice:
                    docEdit.ChangeItensDocument(UserScreem.RecivieingTaxValues());
                    break;
                case Contracts:
                    docEdit.ChangeItensDocument(UserScreem.RecivieingContractsValues());
                    break;
                case FuntionalitiesLicenses:
                    docEdit.ChangeItensDocument(UserScreem.RecivieingLicensesValues());
                    break;
            }

            Console.Clear();
            docEdit.ScreemDocument();
        }
    }
}
