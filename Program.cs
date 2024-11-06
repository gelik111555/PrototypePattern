using PrototypePattern;

class Program
{
    static void Main(string[] args)
    {
        ConcretePrototype original = new("John", 30);

        // Клонирование объекта
        ConcretePrototype clone = (ConcretePrototype)original.Clone();

        // Изменение клона
        clone.Name = "Jane";
        clone.Age = 25;

        Console.WriteLine("Оригинал: " + original);
        Console.WriteLine("Клон: " + clone);
    }
}
