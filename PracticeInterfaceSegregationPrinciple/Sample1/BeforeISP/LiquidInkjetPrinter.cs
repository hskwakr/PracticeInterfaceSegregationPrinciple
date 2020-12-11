namespace PracticeInterfaceSegregationPrinciple.Sample1.BeforeISP
{
    public class LiquidInkjetPrinter : IPrinterTasks
    {
        public string Print(string content)
        {
            return this.GetType().Name + " Print : " + content;
        }

        public string Scan(string content)
        {
            return this.GetType().Name + " Scan : " + content;
        }

        public string PrintDuplex(string PrintDuplexContent)
        {
            throw new System.NotImplementedException();
        }

        public string Fax(string FaxContent)
        {
            throw new System.NotImplementedException();
        }
    }
}
