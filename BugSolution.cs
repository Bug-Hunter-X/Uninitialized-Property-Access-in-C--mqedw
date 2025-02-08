public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Initialize the property in the constructor before using it
        Console.WriteLine(MyProperty); 
    }
}