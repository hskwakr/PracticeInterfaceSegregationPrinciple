namespace PracticeInterfaceSegregationPrinciple.Sample2.BeforeISP
{
    public class MultiFunctionalCar : IVehicle
    {
        public string Drive()
        {
            return this.GetType().Name + " Drive";
        }

        public string Fly()
        {
            return this.GetType().Name + " Fly";
        }
    }
}
