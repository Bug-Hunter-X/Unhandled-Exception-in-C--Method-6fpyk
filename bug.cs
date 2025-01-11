public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        //Error prone code
        int anotherVariable = MyProperty + 10;
        if (anotherVariable > 20)
        {
            Console.WriteLine("Another variable is greater than 20");
        }
        else
        {
            throw new Exception("Another variable is not greater than 20");
        }
    }
}