using DevInDocuments.Entities.Company;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal class UserStream
    {
        internal static int RecivieDocCode()
        {
            Console.WriteLine("Enter with Document code:");
            _ = int.TryParse(Console.ReadLine(), out var code);
            return code;
        }

        public static void RegisteringDocument(DevInDocument docCreation)
        {
            try
            {
                switch (docCreation.GetType().Name)
                {
                    case "TaxInvoice":
                        docCreation = UserScreem.RecivieingTaxValues();
                        break;
                    case "Contracts":
                        docCreation = UserScreem.RecivieingContractsValues();
                        break;
                    case "FuntionalitiesLicenses":
                        docCreation = UserScreem.RecivieingLicensesValues();
                        break;
                }

                if (CheckDocumentToConfirm(docCreation) == "1")
                {
                    docCreation.RegisterDocument(GeneralData.documentsList, docCreation);
                }
                Console.Clear();
            }
            catch
            {
                ScreemMessage.ClearRedAlert(0);
            }
        }

        public static void EditingDocument()
        {
            var docEdit = GeneralData.SearchOneDocument(RecivieDocCode());

            try
            {
                switch (docEdit)
                {
                    case TaxInvoice:
                        var newTax = UserScreem.RecivieingTaxValues();
                        if (CheckDocumentToConfirm(newTax) == "1")
                            docEdit.ChangeItensDocument(newTax);
                        break;
                    case Contracts:
                        var newContract = UserScreem.RecivieingContractsValues();
                        if (CheckDocumentToConfirm(newContract) == "1")
                            docEdit.ChangeItensDocument(newContract);
                        break;
                    case FuntionalitiesLicenses:
                        var newLicence = UserScreem.RecivieingLicensesValues();
                        if (CheckDocumentToConfirm(newLicence) == "1")
                            docEdit.ChangeItensDocument(newLicence);
                        break;
                }
            }
            catch
            {
                ScreemMessage.ClearRedAlert(0);
            }
            UserScreem.MainMenu();
        }

        public static void EditingDocumentStatus()
        {
            try
            {
                var docEdit = GeneralData.SearchOneDocument(RecivieDocCode());
                DocumentStatus status = UserScreem.ChooseStatus();
                docEdit.ChangeDocumentStatus(status);
            }
            catch
            {
                ScreemMessage.ClearRedAlert(0);
            }
            UserScreem.MainMenu();
        }

        private static string CheckDocumentToConfirm(DevInDocument docCreation)
        {
            Console.Clear();
            docCreation.ScreemDocument();
            ScreemMessage.YellowAlert(0);
            ScreemMessage.RedAlert(1);
            return Console.ReadLine();
        }

        public static TaxType ChoosenTaxType(string value)
        {
            TaxType _taxType = TaxType.Other;

            switch (value)
            {
                case "0":
                    _taxType = TaxType.ICMS;
                    return _taxType;
                case "1":
                    _taxType = TaxType.IPI;
                    return _taxType;
                case "2":
                    _taxType = TaxType.IOF;
                    return _taxType;
                case "3":
                    break;
                default:
                    ScreemMessage.RedAlert(0);
                    _taxType = ChoosenTaxType(Console.ReadLine());
                    break;
            }
            return _taxType;
        }

        public static Operation ChoosenOperationType(string value)
        {
            Operation _operation = Operation.Other;

            switch (value)
            {
                case "0":
                    _operation = Operation.Industry;
                    return _operation;
                case "1":
                    _operation = Operation.Agricultural;
                    return _operation;
                case "2":
                    _operation = Operation.Metallurgical;
                    return _operation;
                case "3":
                    _operation = Operation.Technology;
                    return _operation;
                case "4":
                    break;
                default:
                    ScreemMessage.RedAlert(0);
                    _operation =  ChoosenOperationType(Console.ReadLine());
                    break;
            }
            return _operation;
        }

        public static DocumentStatus ChoosenStatusType(string value)
        {
            DocumentStatus status = DocumentStatus.InvalidOption;
            switch (value)
            {
                case "0":
                    return DocumentStatus.Active;
                case "1":
                    return DocumentStatus.Processing;
                case "2":
                    return DocumentStatus.Suspended;
                default:
                    ScreemMessage.RedAlert(0);
                    break;
            }
            return status;
        }
    }
}
