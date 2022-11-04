namespace DevInDocuments.Features
{
    public enum TaxType
    {
        ICMS,
        IPI,
        IOF,
        Other
    }

    public enum Operation
    {
        Industry,
        Agricultural,
        Metallurgical,
        Technology,
        Other
    }

    public enum DocumentStatus
    {
        Active,
        Processing,
        Suspended,
        InvalidOption
    }

    public enum WarningColor
    {
        Ok,
        Warning,
        Error
    }
}