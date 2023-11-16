namespace Learning_2;

public class FirstTask
{
    private int firstNumber;
    private int secondNumber;

    public void InputNumber()
    {
        Console.WriteLine("Input the first number : ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the second number : ");
        secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber == secondNumber)
        {
            Console.WriteLine(firstNumber + " and " + secondNumber + " are equal ");
        }
        else
        {
           Console.WriteLine("Inputed number are not equal");
        }
    }
}