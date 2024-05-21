using System.Globalization;
using Newtonsoft.Json;

namespace sr;

class Program
{
    public static event Action MethodCalled;

    public static void Main(string[] args)
    {
        // Подписываемся на событие
        MethodCalled += OnMethodCalled;

        // Вызываем метод
        MyMethod();

        // Отписываемся от события
        MethodCalled -= OnMethodCalled;
    }

    public static void MyMethod()
    {
        Console.WriteLine("MyMethod вызван.");

        // Вызов события
        MethodCalled?.Invoke();
    }

    public static void OnMethodCalled()
    {
        Console.WriteLine("Действие, выполненное при вызове метода.");
    }
 //   JsonConvert.SerializeObject<List<User>>(@"C:\Users\arman\source\repos\salon\sr\FileSystem.json");
}