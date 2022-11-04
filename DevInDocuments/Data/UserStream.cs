using DevInDocuments.Entities.Company;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal class UserStream
    {
        internal static int RecivieDocCode()
        {
            ScreemMessage.FormsMessage(15);
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
                        docCreation = RecivieingTaxValues();
                        break;
                    case "Contracts":
                        docCreation = RecivieingContractsValues();
                        break;
                    case "FuntionalitiesLicenses":
                        docCreation = RecivieingLicensesValues();
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
                        var newTax = RecivieingTaxValues();
                        if (CheckDocumentToConfirm(newTax) == "1")
                            docEdit.ChangeItensDocument(newTax);
                        break;
                    case Contracts:
                        var newContract = RecivieingContractsValues();
                        if (CheckDocumentToConfirm(newContract) == "1")
                            docEdit.ChangeItensDocument(newContract);
                        break;
                    case FuntionalitiesLicenses:
                        var newLicence = RecivieingLicensesValues();
                        if (CheckDocumentToConfirm(newLicence) == "1")
                            docEdit.ChangeItensDocument(newLicence);
                        break;
                }
            }
            catch
            {
                ScreemMessage.ClearRedAlert(0);
            }
            Console.Clear();
            UserScreem.MainMenu();
        }

        public static void EditingDocumentStatus()
        {
            try
            {
                var docEdit = GeneralData.SearchOneDocument(RecivieDocCode());
                DocumentStatus status = ChooseStatus();
                docEdit.ChangeDocumentStatus(status);
            }
            catch
            {
                ScreemMessage.ClearRedAlert(1);
            }
            Console.Clear();
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

        public static TaxInvoice RecivieingTaxValues()
        {
            ScreemMessage.FormsMessage(0);
            string newEstablishmentName = Console.ReadLine();
            ScreemMessage.FormsMessage(1);
            string newCnpj = Console.ReadLine();
            ScreemMessage.FormsMessage(2);
            string newTotalValue = Console.ReadLine();
            ScreemMessage.FormsMessage(3);
            string newSelledProductName = Console.ReadLine();
            ScreemMessage.FormsMessage(4);
            ScreemMessage.YellowAlert(1);
            TaxType newTaxType = UserStream.ChoosenTaxType(Console.ReadLine());
            ScreemMessage.FormsMessage(5);
            string newTotalTaxValue = Console.ReadLine();

            return new TaxInvoice(GeneralData._employee.Id, newEstablishmentName, newCnpj, decimal.Parse(newTotalValue),
                                  newSelledProductName, newTaxType, decimal.Parse(newTotalTaxValue));
        }

        public static Contracts RecivieingContractsValues()
        {
            ScreemMessage.FormsMessage(0);
            string newEstablishmentName = Console.ReadLine();
            ScreemMessage.FormsMessage(1);
            string newCnpj = Console.ReadLine();
            ScreemMessage.FormsMessage(6);
            string newGoals = Console.ReadLine();
            ScreemMessage.FormsMessage(7);
            string[] newWitnessName = { "", "" };
            newWitnessName[0] = Console.ReadLine();
            ScreemMessage.FormsMessage(8);
            newWitnessName[1] = Console.ReadLine();
            ScreemMessage.FormsMessage(9);
            string year = Console.ReadLine();
            ScreemMessage.FormsMessage(10);
            string month = Console.ReadLine();
            ScreemMessage.FormsMessage(11);
            string day = Console.ReadLine();

            return new Contracts(GeneralData._employee.Id, newEstablishmentName, newCnpj, newGoals, newWitnessName,
                                 new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)));
        }

        public static FuntionalitiesLicenses RecivieingLicensesValues()
        {
            ScreemMessage.FormsMessage(0);
            string newEstablishmentName = Console.ReadLine();
            ScreemMessage.FormsMessage(1);
            string newCnpj = Console.ReadLine();
            ScreemMessage.FormsMessage(12);
            string newAdress = Console.ReadLine();
            ScreemMessage.FormsMessage(13);
            ScreemMessage.YellowAlert(2);
            Operation newOperation = UserStream.ChoosenOperationType(Console.ReadLine());

            return new FuntionalitiesLicenses(GeneralData._employee.Id, newEstablishmentName, newCnpj, newAdress, newOperation);
        }

        public static DocumentStatus ChooseStatus()
        {
            ScreemMessage.FormsMessage(14);
            ScreemMessage.YellowAlert(3);
            DocumentStatus status = UserStream.ChoosenStatusType(Console.ReadLine());

            return status;
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
            DocumentStatus status;
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
                    status = ChoosenStatusType(Console.ReadLine());
                    break;
            }
            return status;
        }
    }
}
