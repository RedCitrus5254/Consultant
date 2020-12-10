using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class FileWorker
    {

        public void ProcessingFiles(List<string> fileNames, string outputDir = "")
        {
            fileNames.AsParallel().ForAll(x => AddDateToFile(x, outputDir));
        }

        private void AddDateToFile(string inputFilePath, string outputDir = "")
        {
            try
            {
                string text = File.ReadAllText(inputFilePath);

                DateTime datetime = GetNextWorkDayDate();

                text = text.Replace("$$18", $"{datetime.ToShortDateString()}{Environment.NewLine}");

                if (!outputDir.Equals(""))
                {
                    string outputPath = outputDir + "\\" + Path.GetFileName(inputFilePath);

                    File.WriteAllText(outputPath, text);
                }
                else
                {
                    File.WriteAllText(inputFilePath, text);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private DateTime GetNextWorkDayDate()
        {
            DateTime now = DateTime.Now;
            int day = (int)now.DayOfWeek;
            if (day > 4)
            {
                int offset = 7 - day; 
                now = now.AddDays(offset);// если сейчас пт, сб или вс то добавляем дней до вс 
            }
            now = now.AddDays(1);
            
            return now;
        }
    }
}
