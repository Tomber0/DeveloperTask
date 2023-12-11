using DeveloperTask.Task1;
using DeveloperTask.Task2;
using System.IO;
using System.Text;

namespace DeveloperTask.Task3
{
    internal static class VehicleViewer
    {
        public static void ViewVehicles() 
        {
            foreach (var item in InstanceService<Vehicle>.GetInstances().OrderBy(t => t.GetType().Name).ToList())
            {
                Console.WriteLine(item.GetType().Name);
            }
        }

        public static IEnumerable<Vehicle> SearchForVehicles(string namePart) 
        {
            return InstanceService<Vehicle>.GetInstances().Where(i => i.GetType().Name.ToLower().Contains(namePart.ToLower())).ToList();
        }

        public static async void SaveVehicles() 
        {
            StringBuilder instances = new StringBuilder();
            foreach (var instance in InstanceService<Vehicle>.GetInstances())
            {
                instances.AppendLine($"{instance.GetType().Name.ToString()}:\n{instance.ToString()}");
            }
            using (StreamWriter streamWritter = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "output.txt")))
            {
                await streamWritter.WriteLineAsync(instances.ToString());
            }

        }
    }
}
