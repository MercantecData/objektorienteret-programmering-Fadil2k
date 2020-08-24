using System;
using System.Threading.Tasks;

namespace GuessANumber
{
    public class Game
    {
        public static void Begin()
        {
            Console.Clear();
            TimerClass.newToken();
            Console.ReadKey();

            var task = TimerClass.Timer(1, 10);
            GAME(1, 10, task);
        }

        public static void GAME(int minRandomNumber, int maxRandomNumber, Task task)
        {
            var answer = Console.ReadLine();

            var num = GenNumber.Random(1, 10);

            while (answer != num.ToString() && task.IsCompleted == false)
            {
                Console.WriteLine($"The number was: {num} - Better luck next time.");
                answer = Console.ReadLine();
            }

            if (answer == num.ToString())
            {
                Console.WriteLine($"How did you know that? The number is {num}");
                TimerClass.cancel();
                Console.ReadKey();
                Begin();
            }
            else
            {
                Console.Clear();
                TimerClass.cancel();
                Console.WriteLine($"The number was: {num} - Better luck next time.");

                Console.ReadKey();
                Begin();
            }
        }
    }
}