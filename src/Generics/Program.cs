
GenericMethodExample example = new();

example.PrintValue(10);
example.PrintValue("Hello world");
example.PrintValue(3.14);

GenericClass<int> intContainer = new(23);
GenericClass<string> stringContainer = new("Hello world");

intContainer.DisplayValue();
stringContainer.DisplayValue();

// Generic types in methods
public class GenericMethodExample
{
    public void PrintValue<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
    }
}


// Generic types in classes
public class GenericClass<T>
{
    private T _value;

    public GenericClass(T value)
    {
        _value = value;
    }

    public void DisplayValue()
    {
        Console.WriteLine($"Value: {_value}");
    }
}

// Constraint new(): T should have constructor by default.
public class Factory<T> where T : new()
{
    public T CreateInstance()
    {
        return new T();
    }
}

// Constraint struct: T should be value type (struct).
public class NumericCalculator<T> where T : struct
{
    public T Add(T a, T b)
    {
        return (dynamic)a + (dynamic)b;
    }
}

// Constraint class: T should be ref type (class).
public class ReferenceContainer<T> where T : class
{
    private T _value;

    public ReferenceContainer(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }
}


// Constraint interface: T should implement interface IComparable<T>.
public class Sorter<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        Array.Sort(array);
    }
}

// Constraint abstract class: T should be derived from abstract class Shape.
public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}

public class ShapeCalculator<T> where T : Shape
{
    public double CalculateArea(T shape)
    {
        return shape.Area();
    }
}

