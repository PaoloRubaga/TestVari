using AsyncTask.Models;
using System.Diagnostics;

namespace AsyncTask
{
    internal class GiornataAsyncV2
    {
        private static async Task<PanniLavatrice> FareLavatrice()
        {
            Console.WriteLine("inizio lavaggio lavatrice");
            await Task.Delay(TempiOperazioni.TempoLavatrice);
            Console.WriteLine($"fine lavatrice in {TempiOperazioni.TempoLavatrice}");

            return new PanniLavatrice();
        }
        private static async Task StendiPanni(PanniLavatrice panni)
        {
            Console.WriteLine("inizio a stendere i panni");
            await Task.Delay(TempiOperazioni.TempoStenderePanni);
            Console.WriteLine($"fine lavatrice in {TempiOperazioni.TempoStenderePanni}");
        }
        private static async Task<RicettaMamma> ChiamareMamma()
        {

            Console.WriteLine("chiamo mamma");
            await Task.Delay(TempiOperazioni.TempoChiamataMamma);
            Console.WriteLine($"fine chiamata mamma in {TempiOperazioni.TempoChiamataMamma}");

            return new RicettaMamma();

        }
        private static async Task<Spesa> FareSpesa()
        {
            Console.WriteLine("inizio spesa");
            await Task.Delay(TempiOperazioni.TempoFareSpesa);
            Console.WriteLine($"fine spesa in {TempiOperazioni.TempoFareSpesa}");

            return new Spesa();
        }
        private static async Task PreparareCena(Spesa spesa, RicettaMamma ricetta)
        {
            Console.WriteLine("inizio Preparare cena");
            await Task.Delay(TempiOperazioni.TempoPreparareCena);
            Console.WriteLine($"fine Preparare cena in {TempiOperazioni.TempoPreparareCena}");
        }
        private static Task VedereFilm()
        {
            Console.WriteLine("Guardo film");
            return Task.CompletedTask;
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
