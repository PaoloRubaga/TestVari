using Serilog;
using Serilog.Events;
using System;
using System.Windows.Forms;

namespace TestPerLog
{


    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Log.Logger = new LoggerConfiguration()
            //    .WriteTo.Logger(lc => lc
            //        .WriteTo.File(
            //            path: "primo.txt",
            //            rollingInterval: RollingInterval.Day,
            //            retainedFileCountLimit: 15,
            //            outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} {Level:u3}] {Message:l}{NewLine}{Exception}"
            //            //restrictedToMinimumLevel: LogEventLevel.Information
            //            ))//con questo filtro nei log scrive solo quelli di livello information
            //    .WriteTo.Logger(lc => lc
            //        //.Filter.ByIncludingOnly(e => e.Properties.ToString().Contains("ciaone"))
            //        //.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Debug)
            //        .WriteTo.File(
            //            path: "secondo.txt",
            //            rollingInterval: RollingInterval.Day,
            //            retainedFileCountLimit: 15
            //            ))
            //    .CreateLogger();

            Log.Logger = new LoggerConfiguration()
               .WriteTo.Logger(lc => lc
                   //.Filter.ByExcluding()
                   //.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Information)
                   .WriteTo.File(
                       path: "logImportaDatiGeeoApp-all.txt",
                       rollingInterval: RollingInterval.Day,
                       retainedFileCountLimit: 15,
                       outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} {Level:u3}] {Message:l}{NewLine}{Exception}"
                       //restrictedToMinimumLevel: LogEventLevel.Information
                       ))//con questo filtro nei log scrive solo quelli di livello information
               .WriteTo.Logger(lc => lc
                   //.Filter.ByIncludingOnly(e => e.Properties.ContainsKey("ciaone"))
                   //.Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Debug)
                   .WriteTo.File(
                       path: "logImportaDatiGeeoApp-errori.txt",
                       rollingInterval: RollingInterval.Day,
                       retainedFileCountLimit: 15,
                       restrictedToMinimumLevel: LogEventLevel.Warning
                       ))
               .WriteTo.Logger(lc => lc
                .MinimumLevel.Fatal()
                .WriteTo.Async(a => a.File("fatal.txt")))
               .CreateLogger();



            //Log.Logger = new LoggerConfiguration()
            //    .WriteTo.Async(a => a.File("provaAsync.log"))

            //    .CreateLogger();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
            //Application.Run(new FormEmail());
        }
    }
}
