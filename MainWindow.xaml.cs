
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace KursovayaKamashevaVisiner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click_Read(object sender, RoutedEventArgs e)
        {
            var result = VigenereCipher.VCode(WorkWithFile.ReadFile(), "скорпион", false);
            TextDeshifr.Text = result;
        }
        private void Button_Click_Shifr(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TextForShifr.Text) && !String.IsNullOrEmpty(Key.Text))
            {
                var result = VigenereCipher.VCode(TextForShifr.Text, Key.Text);
                TextShifr.Visibility = Visibility.Visible;
                OnSave.Visibility = Visibility.Visible;
                TextShifr.Text = result;
               
            }
            else
            {
                MessageBox.Show("Даже поля заполнить не можешь?");
            }


        }
        private void Button_Click_Save1(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TextDeshifr.Text))
            {
                WorkWithFile.SaveFile(TextDeshifr.Text);             
                TextDeshifr.Clear();
            }
            else
            {
                MessageBox.Show("Зачем тебе сохранять пустой файл?");
            }
            
        }
        private void Button_Click_Save2(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TextShifr.Text))
            {
                WorkWithFile.SaveFile(TextShifr.Text);
                TextForShifr.Clear();
                TextShifr.Clear();
                Key.Clear();
            }
            else
            {
                MessageBox.Show("Зачем тебе сохранять пустой файл?");
            }
            
        }
    }
}
