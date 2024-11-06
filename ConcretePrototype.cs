namespace PrototypePattern;

internal class ConcretePrototype : IPrototype
{
    public string Name { get; set; }
    public int Age { get; set; }

    public ConcretePrototype(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Реализация метода клонирования
    public IPrototype Clone()
    {
        return new ConcretePrototype(Name, Age);  // Поверхностное клонирование
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
