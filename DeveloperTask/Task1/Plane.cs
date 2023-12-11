namespace DeveloperTask.Task1
{
    internal class Plane : Vehicle
    {
        public Plane():base() { }

        public Plane(float topSpeed, string name, int passengerCount) : base(topSpeed, name, passengerCount)
        {
        }
    }
}
