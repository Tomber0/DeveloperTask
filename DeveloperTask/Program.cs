using DeveloperTask.Task1;
using DeveloperTask.Task2;

namespace DevTask
{
    public class Program 
    {
        public static void Main() 
        {
            var inst = InstanceService<Vehicle>.GetInstances();
        }
    }
}