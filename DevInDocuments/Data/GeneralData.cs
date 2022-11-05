using DevInDocuments.Entities.Company;
using DevInDocuments.Entities.Person;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal class GeneralData
    {
        public static List<DevInDocument> documentsList;
        public static Employee _employee;

        public static void InitializeList()
        {
            documentsList = new List<DevInDocument>();
        }

        public static void InitializeMenu(Employee employee)
        {
            _employee = employee;
        }
    
        public static void SearchByStatus(DocumentStatus value)
        {
            foreach(var item in documentsList)
            {
                if (item.DocumentStatus == value)
                    item.ScreamDocument();
            }
        }

        public static DevInDocument SearchOneDocument(int code)
        {
            foreach (var doc in documentsList)
            {
                if (doc.DocumentCode == code)
                {
                    return doc;
                }
            }
            ScreamMessage.ClearRedAlert(1);
            return null;
        }
    }
}
