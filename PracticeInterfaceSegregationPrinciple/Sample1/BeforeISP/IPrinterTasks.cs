namespace PracticeInterfaceSegregationPrinciple.Sample1.BeforeISP
{
    public interface IPrinterTasks
    {
        string Print(string PrintContent);
        string Scan(string ScanContent);
        string Fax(string FaxContent);
        string PrintDuplex(string PrintDuplexContent);
    }
}
