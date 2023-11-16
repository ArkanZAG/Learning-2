namespace Learning_2;

public class SecondTask
{
    private int inputedNumber;

    public void InputNumber()
    {
        inputedNumber = int.Parse(Console.ReadLine());

        if (inputedNumber % 2 == 0)
        {
            Console.WriteLine(inputedNumber + " is an even number");
        }
        else
        {
            Console.WriteLine(inputedNumber + " is an odd number");
        }
    }
}