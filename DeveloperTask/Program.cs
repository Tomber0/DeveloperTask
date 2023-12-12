using DeveloperTask.Task1;
using DeveloperTask.Task2;
using DeveloperTask.Task3;
using DeveloperTask.Task4;

namespace DevTask
{
    public class Program 
    {
        public static void Main() 
        {
            var c = Problems.MissingElements(new int[] {1,3,4 });
            var c2 =c.ToList();
        }
    }
}