namespace PracticeInterfaceSegregationPrinciple.Sample1.AfterISP
{
    public interface IPrinterTasks
    {
        string Print(string PrintContent);
        string Scan(string ScanContent);
    }
}
