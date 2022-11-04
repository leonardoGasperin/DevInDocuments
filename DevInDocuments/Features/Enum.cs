namespace DevInDocuments.Features
{
    internal enum TaxType
    {
        ICMS,
        IPI,
        IOF,
        Other
    }

    internal enum Operation
    {
        Industry,
        Agricultural,
        Metallurgical,
        Technology,
        Other
    }

    internal enum DocumentStatus
    {
        Active,
        Processing,
        Suspended,
        InvalidOption
    }

    internal enum MenuType
    {
        Main,
        Register,
        ScremmDoc,
        Exit
    }
}