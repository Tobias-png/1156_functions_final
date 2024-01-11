using System.Diagnostics.Metrics;

internal class TestApp
{
    public void Run()
    {
        Counter();
    }

    public void Counter()
    {
        bool proceed = true;
        int hodnota = 0;

        while (proceed)
        {
            Console.WriteLine("Zadejte číslo");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Zadaná hodnota je {userInput}");
            if (userInput == "exit")
            {
                proceed = false;
            }
            else 
            {
                int input = SafelyConvertToInt(userInput);
                hodnota += input;
                Console.WriteLine(hodnota);
            }
        }
    }
    public int SafelyConvertToInt(string x)
    {
        if (int.TryParse(x, out int result))
        {
            return result;
        }
        else
        {
            return 0;
        }
    }
}