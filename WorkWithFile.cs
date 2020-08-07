using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KursovayaKamashevaVisiner
{
    public class WorkWithFile
    {
        public static string ReadFile()
        {
            var fileContent = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {

                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream, Encoding.Default, true))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            return fileContent;
        } 
        public static void SaveFile(string result)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, result, Encoding.UTF8);
            }
            MessageBox.Show("Файл успешно сохранён!\nПуть файла: " + saveFileDialog.FileName);

        } 
    }
}
