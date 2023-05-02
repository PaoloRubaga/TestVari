using Serilog;
using System;
using System.Threading;
using System.Windows.Forms;


namespace TestPerLog
{
    class MethodInfo
    {
        public string MethodName { get; set; }
        public int IdThread { get; set; }

    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var thisMethod = new MethodInfo { IdThread = Thread.CurrentThread.ManagedThreadId, MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name };
            Log.Information("Informazione sei qua: {@MethodInfo} ", thisMethod);//per nome thread: Thread.CurrentThread.Name
            Log.Information("ciaone test bla bla bla");
            Log.Warning("log di warning");
            Log.Error("log di error");
            Log.Fatal("log di Fatal");

            //Log.Warning("Attenzione sei nel metodo: {0} e nel thread: {1}", System.Reflection.MethodBase.GetCurrentMethod().Name, Thread.CurrentThread.ManagedThreadId);
            //int i = 99;
            //string MatricolaBase = "08058480970001A000";
            //int startIndex = 15;
            //int numCharsToReplace = i.ToString().Length < 4 ? Math.Min(MatricolaBase.Length, i.ToString().Length) : 3;
            //string MatricolaOK = MatricolaBase.Substring(0, MatricolaBase.Length - numCharsToReplace) + i.ToString();

            //Log.CloseAndFlush();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string strProva, matricola;

            //for (int i = 0; i < 20; i++)
            //{
            //    //Console.WriteLine(i.ToString("08058480970001A000"));
            //    matricola = i.ToString("08058480970001A000");
            //    strProva = $@"INSERT INTO tbAnag_Dispositivi (Matricola, Descrizione, Modello, Tipo, DataOraIns, CodSoggetto, DescSoggetto)
            //                 VALUES ('{matricola}', 'SYREN MOVE', 'MOVE', 'S', '02/10/2022', '', '');";
            //    Console.WriteLine(strProva);
            //}

            Log.Warning("log di warning tasto 2");
            Log.Fatal("log di fatal tasto 2");


        }
    }
}
