namespace PracticeInterfaceSegregationPrinciple.Sample2.BeforeISP
{
    public class Airplane : IVehicle
    {
        public string Drive()
        {
            throw new System.NotImplementedException();
        }

        public string Fly()
        {
            return this.GetType().Name + " Fly";
        }
    }
}
