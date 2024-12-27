public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior
        Console.WriteLine(MyProperty); // This line might print 0, which is the default value, or throw an exception in some cases
    }
}