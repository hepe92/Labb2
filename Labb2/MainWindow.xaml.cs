using System;
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

namespace Labb2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            Answer a = new Answer();
            string answerText;

            if (CheatBox.IsChecked == true)
            {
                answerText = a.CheatRandGen().ToString();          
            }
            else
            {
                answerText = a.RandGen().ToString();
            }

            ReturnAnswer.Content = NameTextBox.Text + "\n" + answerText;
            HistoryListBox.Items.Add(NameTextBox.Text + "\n" + answerText);
        }

        private void HistoryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
