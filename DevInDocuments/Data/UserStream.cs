using DevInDocuments.Entities.Company;

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

            ///TODO
            ///try figure out how i can refatore it
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Document not be found or code must be only interger.\nTry again");
            Console.ResetColor();
            
            return SearchOneDocument(RecivieDocCode());

        }

        public static void RegisteringDocument()
        {

        }

        public static void EditingDocument()
        {

        }
    }
}
