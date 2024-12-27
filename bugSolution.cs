public class MyClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public MyClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now you are guaranteed to have a predictable value
    }
}
