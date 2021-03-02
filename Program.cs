using System;
Main();

void Main()
{
    string question = "empty";
    Random random = new Random();

    while (question != "")
    {
        Console.WriteLine("Ask away, child");
        question = Console.ReadLine();

        if (question == "")
        {
            Console.WriteLine("You missed your chance");
            break;
        }


    }
}
