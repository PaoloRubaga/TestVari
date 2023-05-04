using System.Diagnostics;

namespace AsyncTask
{
    public static class SyncExample2
    {
        public static int IstruzioneA()
        {
            Console.WriteLine("Istruzione A start");
            Thread.Sleep(4000); //simulo operazione pesante
            Console.WriteLine("Istruzione A End");

            return 5;
        }

        public static int IstruzioneB()
        {
            Console.WriteLine("Istruzione B start");
            Thread.Sleep(3000);
            Console.WriteLine("Istruzione B End");

            return 7;
        }

        public static void IstruzioneC(int inputIstruzioneA, int inputIstruzioneB)
        {
            Console.WriteLine("Istruzione C start");
            Thread.Sleep(2000);


            int somma = inputIstruzioneA + inputIstruzioneB;
            Console.WriteLine("Istruzione C End - risultato : " + somma);
        }

        public static void Execute()
        {
            Console.WriteLine("---------------------- Esecuzione Sincrona Esempio 2 ----------------------");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var resultA = IstruzioneA();
            var resultB = IstruzioneB();
            IstruzioneC(resultA, resultB);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string elaspsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine("tempo di esecuzione : " + elaspsedTime);
            Console.WriteLine("----------------------------------------------------------------------------");

        }
    }
}
