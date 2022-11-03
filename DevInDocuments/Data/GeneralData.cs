using DevInDocuments.Entities.Company;
using DevInDocuments.Features;

namespace DevInDocuments.Data
{
    internal static class GeneralData
    {
        public static List<DevInDocument> documentsList;

        public static void InitializeList()
        {
            documentsList = new List<DevInDocument>();
        }
    
        public static void SearchByStatus(DocumentStatus value)
        {
            foreach(var item in documentsList)
            {
                if (item.DocumentStatus == value)
                    item.ScreemDocument();
            }
        }

        public static DevInDocument SearchOneDocument(int code)
        {
            foreach (var doc in GeneralData.documentsList)
            {
                if (doc.DocumentCode == code)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Document Found!\n");
                    Console.ResetColor();
                    return doc;
                }
            }
            return null;
        }
    }
}
