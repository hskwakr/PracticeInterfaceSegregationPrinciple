namespace PracticeInterfaceSegregationPrinciple.Sample2.AfterISP
{
    public class Airplane : IAirplane
    {
        public string Fly()
        {
            return this.GetType().Name + " Fly";
        }
    }
}
