using System;

public class MyGenericClass<T>
{
    private T genericField;

    //value of the generic field
    public void SetGenericField(T value)
    {
        genericField = value;
    }

 
    public T GetGenericField()
    {
        return genericField;
    }
}

// display the field value
public static class GenericMethods
{
    public static void DisplayFieldValue<T>(MyGenericClass<T> obj)
    {
        Console.WriteLine($"Field value: {obj.GetGenericField()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //instance with an integer
        MyGenericClass<int> intInstance = new MyGenericClass<int>();
        intInstance.SetGenericField(10);
        GenericMethods.DisplayFieldValue(intInstance); 

        //instance with a string
        MyGenericClass<string> stringInstance = new MyGenericClass<string>();
        stringInstance.SetGenericField("Hi, Fadji!");
        GenericMethods.DisplayFieldValue(stringInstance); 
    }
}

