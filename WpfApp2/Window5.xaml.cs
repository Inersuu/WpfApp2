using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = (DatePicker)sender;
            MessageBox.Show("Выбранная дата: " + datePicker.SelectedDate.Value.ToShortDateString());
            TB1.Text = datePicker.SelectedDate.Value.ToShortDateString();
            
        }

        private void Cl1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            System.Windows.Controls.Calendar calendar = (System.Windows.Controls.Calendar)sender;
            MessageBox.Show("Выбранная дата: " + calendar.SelectedDate.Value.ToShortDateString());
            TB2.Text = calendar.SelectedDate.Value.ToShortDateString();
        }
    }
}
