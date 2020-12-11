namespace PracticeInterfaceSegregationPrinciple.Sample1.AfterISP
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
    }
}
