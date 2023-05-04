using System.Diagnostics;

namespace AsyncTask
{
    public static class SyncExample1
    {
        public static void IstruzioneA()
        {
            Console.WriteLine("Istruzione A start");
            Thread.Sleep(4000); //simulo operazione pesante
            Console.WriteLine("Istruzione A End");
        }

        public static void IstruzioneB()
        {
            Console.WriteLine("Istruzione B start");
            Thread.Sleep(3000);
            Console.WriteLine("Istruzione B End");
        }

        public static void IstruzioneC()
        {
            Console.WriteLine("Istruzione C start");
            Thread.Sleep(2000);
            Console.WriteLine("Istruzione C End");
        }

        public static void Execute()
        {
            Console.WriteLine("---------------------- Esecuzione Sincrona Esempio 1 ----------------------");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            IstruzioneA();
            IstruzioneB();
            IstruzioneC();

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string elaspsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine("tempo di esecuzione : " + elaspsedTime);
            Console.WriteLine("----------------------------------------------------------------------------");

        }
    }
}
