namespace PracticeInterfaceSegregationPrinciple.Sample2.AfterISP
{
    public class MultiFunctionalCar : IMultiFunctionalVehicle
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
