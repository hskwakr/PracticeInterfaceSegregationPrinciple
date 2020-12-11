namespace PracticeInterfaceSegregationPrinciple.Sample1.AfterISP
{
    public class HPLaserJetPrinter
        : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public string Print(string content)
        {
            return this.GetType().Name + " Print : " + content;
        }

        public string Scan(string content)
        {
            return this.GetType().Name + " Scan : " + content;
        }

        public string Fax(string content)
        {
            return this.GetType().Name + " Fax : " + content;
        }

        public string PrintDuplex(string content)
        {
            return this.GetType().Name + " PrintDuplex : " + content;
        }
    }
}
