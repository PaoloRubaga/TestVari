using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestPerLog
{
    
    public class MatricoleQuery
    {
        private string matricolaBase;

        public MatricoleQuery(string _matricolaBase)
        {
            matricolaBase = _matricolaBase;
        }
        
        public void CreaQueryInsert(int inizio, int fine, string descrizione, string modello, string dataInserimento)
        {
            if (!ControlloParametrioOK(inizio, fine, descrizione, modello, dataInserimento))
                return;

            string fileName = "scriptMatricoleSQL2.sql";
            string tmp;
            int startIndex = inizio;
            int endIndex = fine;
            string matricolaOk;
            bool presenzaRiga = false;
            bool presenzaData = dataInserimento != null ? true : false;

            using (StreamWriter writer = File.AppendText(fileName))           

            for (int i = startIndex ; i <= endIndex; i++)
            {
                int numCharsToReplace = i.ToString().Length < 4 ? i.ToString().Length : 3;
                matricolaOk = matricolaBase.Substring(0, matricolaBase.Length - numCharsToReplace) + i.ToString();
                   // matricolaBase.ToString().PadLeft(3, )

                tmp = presenzaData ? $"INSERT INTO tbAnag_Dispositivi (Matricola, Descrizione, Modello, Tipo, DataOraIns, CodSoggetto, DescSoggetto) " +
                                     $"VALUES ('{matricolaOk}', '{descrizione}', '{modello}', 'S', '{dataInserimento}', '', '')"
                                   : $"INSERT INTO tbAnag_Dispositivi (Matricola, Descrizione, Modello, Tipo, CodSoggetto, DescSoggetto) " +
                                     $"VALUES ('{matricolaOk}', '{descrizione}', '{modello}', 'S', '', '')";

                presenzaRiga = ControlloPresenzaRiga(fileName, tmp);

                using (StreamWriter w = File.AppendText(fileName))
                {
                    if (!presenzaRiga)
                        w.WriteLine(tmp);
                }
            }         
        }

        public bool ControlloParametrioOK(int inizio, int fine, string descrizione, string modello, string dataInserimento)
        {
            if (inizio > fine)
                return false;
            if (descrizione.Length == 0 || modello.Length == 0)
                return false;
            //if (dataInserimento == null)
            //    return false;
            return true;
        }

        public bool ControlloPresenzaRiga(string fileName, string tmp)
        {
            string[] lines = File.ReadAllLines(fileName);
            string searchKeyword = tmp;
            bool isStringFound = false;

            foreach (string line in lines)
            {
                if (line.Contains(searchKeyword))
                {
                    isStringFound = true;
                    break;
                }
            }

            if (isStringFound)
                return true;
            else
                return false;
            
        }
    
    }

   


}
