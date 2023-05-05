using AsyncTask.Models;
using System.Diagnostics;

namespace AsyncTask
{
    internal class GiornataAsync
    {
        private static Task<PanniLavatrice> FareLavatrice()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("inizio lavaggio lavatrice");
                Thread.Sleep(TempiOperazioni.TempoLavatrice);
                Console.WriteLine($"fine lavatrice in {TempiOperazioni.TempoLavatrice}");

                return new PanniLavatrice();
            });
        }
        private static Task StendiPanni(PanniLavatrice panni)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("inizio a stendere i panni");
                Thread.Sleep(TempiOperazioni.TempoStenderePanni);
                Console.WriteLine($"fine lavatrice in {TempiOperazioni.TempoStenderePanni}");
            });
        }
        private static Task<RicettaMamma> ChiamareMamma()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("chiamo mamma");
                Thread.Sleep(TempiOperazioni.TempoChiamataMamma);
                Console.WriteLine($"fine chiamata mamma in {TempiOperazioni.TempoChiamataMamma}");

                return new RicettaMamma();
            });
        }
        private static Task<Spesa> FareSpesa()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("inizio spesa");
                Thread.Sleep(TempiOperazioni.TempoFareSpesa);
                Console.WriteLine($"fine spesa in {TempiOperazioni.TempoFareSpesa}");

                return new Spesa();
            });
        }
        private static Task PreparareCena(Spesa spesa, RicettaMamma ricetta)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("inizio Preparare cena");
                Thread.Sleep(TempiOperazioni.TempoPreparareCena);
                Console.WriteLine($"fine Preparare cena in {TempiOperazioni.TempoPreparareCena}");
            });
        }
        private static Task VedereFilm()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Guardo film");
            });
        }

        public static async Task Execute()
        {
            Console.WriteLine("----------------- Esecusione Asincrona Giornata ---------------");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var taskLavatrice = FareLavatrice();
            var taskRicettaMamma = ChiamareMamma();
            var taskSpesa = FareSpesa();

            var panniLavatrice = await taskLavatrice;

            await StendiPanni(panniLavatrice);

            var ricettaMamma = await taskRicettaMamma;
            var spesa = await taskSpesa;

            await PreparareCena(spesa, ricettaMamma);

            await VedereFilm();

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string elaspsedTime = string.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds);
            Console.WriteLine("tempo di esecuzione : " + elaspsedTime);
            Console.WriteLine("----------------------------------------------------------------------------");
        }


    }
}
