namespace Learning_2;

public class ThirdTask
{
    private int currentYear = 2023;
    private int birthYear;

    public void VotingAge()
    {
        birthYear = int.Parse(Console.ReadLine());
        int voteAge = currentYear - birthYear;

        if (voteAge >= 18)
        {
            Console.WriteLine("Your age is "+ voteAge +" Congratulation! You are eligible for casting your vote.");
        }
        else
        {
            Console.WriteLine("Your age is "+ voteAge +" Sorry, You are not eligible for casting your vote.");
        }
    }
}