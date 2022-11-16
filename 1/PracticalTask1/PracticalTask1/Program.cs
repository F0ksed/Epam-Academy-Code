using System;
class MaxNum
{
    static void Main()
    {
        string userInput; int amount, maxAmount;
        Console.WriteLine("Type \"break\" to exit.");
        do
        {
            amount = 0; maxAmount = 0;
            userInput = Console.ReadLine();
            if (userInput.Length > 0)
            {
                amount = 1;
                for (int i = 0; i < userInput.Length - 1; i++)
                {
                    if (userInput[i] != userInput[i + 1])
                    {
                        amount++;
                    }
                    else
                    {
                        if (amount > maxAmount)
                        {
                            maxAmount = amount;
                        }
                        amount = 1;
                    }
                }
                if (amount > maxAmount)
                {
                    maxAmount = amount;
                }
                if (maxAmount == 1)
                {
                    maxAmount = 0;
                }
            }
            Console.WriteLine("Maximum number of unequal consecutive characters is: " +maxAmount);
        }
        while(userInput != "break" && userInput != null);
    }
}
