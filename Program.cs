using System;
using System.Threading;
Main();

void Main()
{
    string question = "dummy text";
    Random random = new Random();

    while (question != "")
    {
        Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /   I am the all knowing voodoo mama moose-moose...
                       |   / \   |    Ask me anything, child...
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        Console.WriteLine("Type your question here:");
        question = Console.ReadLine();

        if (question == "")
        {
            Console.WriteLine("You missed your chance");
            break;
        }
        else
        {

            int answer = random.Next(0, 20);

            switch (answer)
            {
                case 0:
                    Console.WriteLine("Ah yes, I see it now... yes");
                    Thread.Sleep(3500);
                    break;

                case 1:
                    Console.WriteLine("Ask again later");
                    Thread.Sleep(3500);
                    break;

                case 2:
                    Console.WriteLine("Better not tell you now");
                    Thread.Sleep(3500);
                    break;

                case 3:
                    Console.WriteLine("Cannot predict now.");
                    Thread.Sleep(3500);
                    break;

                case 4:
                    Console.WriteLine("Concentrate and ask again.");
                    Thread.Sleep(3500);
                    break;

                case 5:
                    Console.WriteLine("Don't count on it.");
                    Thread.Sleep(3500);
                    break;

                case 6:
                    Console.WriteLine("It is certain");
                    Thread.Sleep(3500);
                    break;

                case 7:
                    Console.WriteLine("It is decidedly so.");
                    Thread.Sleep(3500);
                    break;

                case 8:
                    Console.WriteLine("Most likely");
                    Thread.Sleep(3500);
                    break;

                case 9:
                    Console.WriteLine("My reply is no");
                    Thread.Sleep(3500);
                    break;

                case 10:
                    Console.WriteLine("My sources say no");
                    Thread.Sleep(3500);
                    break;

                case 11:
                    Console.WriteLine("Outlook not so good");
                    Thread.Sleep(3500);
                    break;

                case 12:
                    Console.WriteLine("Outlood good");
                    Thread.Sleep(3500);
                    break;

                case 13:
                    Console.WriteLine("Reply hazy, try again");
                    Thread.Sleep(3500);
                    break;

                case 14:
                    Console.WriteLine("Signs point to yes");
                    Thread.Sleep(3500);
                    break;

                case 15:
                    Console.WriteLine("Very doubtful");
                    Thread.Sleep(3500);
                    break;

                case 16:
                    Console.WriteLine("Without a doubt");
                    Thread.Sleep(3500);
                    break;

                case 17:
                    Console.WriteLine("Yes.");
                    Thread.Sleep(3500);
                    break;

                case 18:
                    Console.WriteLine("Yes - definitely");
                    Thread.Sleep(3500);
                    break;

                case 19:
                    Console.WriteLine("You may rely on it");
                    Thread.Sleep(3500);
                    break;

            }
        }

    }
}
