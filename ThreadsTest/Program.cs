namespace ThreadsTest
{
    internal class Program
    {
        static int _quanti = 1000;
        static void Main(string[] args)
        {
            //_quanti = 1000;
            //Thread t1 = new Thread(StampaAsc);
            //t1.Start();
            //for (int i = 0; i < _quanti; i++) Console.Write("+");

            //Thread.CurrentThread.Name = "main";
            //Console.WriteLine($"Thread: {Thread.CurrentThread.Name} sul processore {Thread.GetCurrentProcessorId()}");
            //DateTime start = DateTime.Now;

            //Thread t1 = new Thread(MetodoDaEseguire);
            //t1.Name = "t1";
            //t1.Start();

            ////Console.WriteLine($"1 Thread t1 attivo: {t1.IsAlive}");
            ////Thread.Sleep(5000);
            ////Console.WriteLine($"2 Thread t1 attivo: {t1.IsAlive}");

            //int quanti = 100000;
            //StreamWriter scrivi = new StreamWriter("file_main.txt");
            //for (int i = 0; i < quanti; i++) scrivi.Write("*");
            //scrivi.Close();

            //t1.Join();



        }

        static void StampaAsc()
        {
            for (int i = 0; i < _quanti; i++) Console.Write("*");
        }

        static void MetodoDaEseguire()
        {
            //Thread.Sleep(1000);
            Console.WriteLine($"A Thread: {Thread.CurrentThread.Name} sul processore {Thread.GetCurrentProcessorId()}");
            Console.WriteLine($"B Thread: {Thread.CurrentThread.Name} sul processore {Thread.GetCurrentProcessorId()}");

            int quanti = 100000;
            StreamWriter scrivi = new StreamWriter("file_thread.txt");

            for (int i = 0; i < quanti; i++) scrivi.Write("*");
            scrivi.Close();

        }
    }
}