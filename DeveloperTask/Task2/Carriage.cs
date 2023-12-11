using DeveloperTask.Task1;

namespace DeveloperTask.Task2
{
    internal class Carriage : Vehicle
    {
        public Carriage():base()
        {
        }

        public Carriage(float topSpeed, string name, int passengerCount) : base(topSpeed, name, passengerCount)
        {
        }
    }
}
