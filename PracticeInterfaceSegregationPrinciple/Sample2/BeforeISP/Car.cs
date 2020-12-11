namespace PracticeInterfaceSegregationPrinciple.Sample2.BeforeISP
{
    public class Car : IVehicle
    {
        public string Drive()
        {
            return this.GetType().Name + " Drive";
        }

        public string Fly()
        {
            throw new System.NotImplementedException();
        }
    }
}
