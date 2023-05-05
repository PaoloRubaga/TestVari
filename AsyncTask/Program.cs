namespace AsyncTask
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //SyncExample2.Execute();
            ////GiornataSync.Execute();
            //await GiornataAsync.Execute();
            //await GiornataAsyncV2.Execute();
            await TaskExample.Execute();
        }
    }
}