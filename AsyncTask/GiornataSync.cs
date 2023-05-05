using AsyncTask.Models;
using System.Diagnostics;

namespace AsyncTask
{
    internal static class GiornataSync
    {
        private static PanniLavatrice FareLaLavatrice()
        {
            Console.WriteLine("inizio lavaggio lavatrice");
            Thread.Sleep(TempiOperazioni.TempoLavatrice);
            Console.WriteLine($"fine lavatrice in {TempiOperazioni.TempoLavatrice}");

            return new PanniLavatrice();
        }

        private static void StendiPanni(PanniLavatrice panni)
        {
            Console.WriteLine("inizio a stendere i panni");
            Thread.Sleep(TempiOperazioni.TempoStenderePanni);
            Console.WriteLine($"fine lavatrice in {TempiOperazioni.TempoStenderePanni}");
        }
        private static RicettaMamma ChiamareMamma()
        {
            Console.WriteLine("chiamo mamma");
            Thread.Sleep(TempiOperazioni.TempoChiamataMamma);
            Console.WriteLine($"fine chiamata mamma in {TempiOperazioni.TempoChiamataMamma}");

            return new RicettaMamma();
        }
        private static Spesa FareSpesa()
        {
            Console.WriteLine("inizio spesa");
            Thread.Sleep(TempiOperazioni.TempoFareSpesa);
            Console.WriteLine($"fine spesa in {TempiOperazioni.TempoFareSpesa}");

            return new Spesa();
        }
        private static void PreparareCena(Spesa spesa, RicettaMamma ricetta)
        {
            Console.WriteLine("inizio spesa");
            Thread.Sleep(TempiOperazioni.TempoFareSpesa);
            Console.WriteLine($"fine spesa in {TempiOperazioni.TempoFareSpesa}");
        }
        public static void VedereFilm()
        {
            Console.WriteLine("Guardo film");
        }
        public static void Execute()
        {
            Console.WriteLine("----------------- Esecusione Sincrona Giornata ---------------");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var panni = FareLaLavatrice();

            StendiPanni(panni);

            var ricetta = ChiamareMamma();
            var spesa = FareSpesa();

            PreparareCena(spesa, ricetta);
            VedereFilm();


            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string elaspsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine("tempo di esecuzione : " + elaspsedTime);
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
