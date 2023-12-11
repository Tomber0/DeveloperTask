using System.Reflection;

namespace DeveloperTask.Task2
{
    internal class InstanceService<T>
    {
        public static IEnumerable<T> GetInstances() 
        {
            var subclasses = Assembly.GetAssembly(typeof(T)).GetTypes().Where(t => t.IsClass && t.IsSubclassOf(typeof(T)));
            List<T> instances = new List<T>();
            foreach (var subclassType in subclasses.ToList())
            {
                instances.Add((T)Activator.CreateInstance(subclassType));
            }
            return instances;
        }
    }
}
