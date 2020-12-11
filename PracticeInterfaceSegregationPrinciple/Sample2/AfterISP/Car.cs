namespace PracticeInterfaceSegregationPrinciple.Sample2.AfterISP
{
    public class Car : ICar
    {
        public string Drive()
        {
            return this.GetType().Name + " Drive";
        }
    }
}
