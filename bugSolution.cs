public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        int anotherVariable = MyProperty + 10;
        if (anotherVariable > 20)
        {
            Console.WriteLine("Another variable is greater than 20");
        }
        else
        {
            throw new MyCustomException("Another variable is not greater than 20", anotherVariable);
        }
    }
}

public class MyCustomException : Exception
{
    public int Value { get; set; }

    public MyCustomException(string message, int value) : base(message)
    {
        Value = value;
    }
}