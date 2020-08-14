using System;
using System.Threading;
using System.Threading.Tasks;

namespace GuessANumber
{
    public class TimerClass
    {
        private static CancellationTokenSource TokenSource = new CancellationTokenSource();

        public static Task Timer(int wait, int time)
        {
            var token = TokenSource.Token;
            var task = new Task(() =>
            {
                for (var i = 0; i < time && !token.IsCancellationRequested; i++)
                {
                    Task.Delay(wait * 1000).Wait();
                    if (!token.IsCancellationRequested) Console.WriteLine($"You have {time - i} seconds left.");
                    time--;
                }
            });
            task.Start();
            return task;
        }

        public static void cancel()
        {
            TokenSource.Cancel();
        }

        public static void newToken()
        {
            TokenSource = new CancellationTokenSource();
        }
    }
}