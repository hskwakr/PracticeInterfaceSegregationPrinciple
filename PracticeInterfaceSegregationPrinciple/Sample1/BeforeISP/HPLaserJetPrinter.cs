namespace PracticeInterfaceSegregationPrinciple.Sample1.BeforeISP
{
    public class HPLaserJetPrinter : IPrinterTasks
    {
        public string Fax(string content)
        {
            return this.GetType().Name + " Fax : " + content;
        }

        public string Print(string content)
        {
            return this.GetType().Name + " Print : " + content;
        }

        public string PrintDuplex(string content)
        {
            return this.GetType().Name + " PrintDuplex : " + content;
        }

        public string Scan(string content)
        {
            return this.GetType().Name + " Scan : " + content;
        }
    }
}
