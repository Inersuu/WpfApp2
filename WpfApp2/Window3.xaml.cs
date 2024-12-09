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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\KorbachevIV\Downloads\2131231.png"));
            MessageBox.Show("ГОООООООООООООООООООООООООООООООООООЛ");
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\KorbachevIV\Downloads\2024-10-30_14-34-13.png"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            this.Close();
            window4.Show();
        }
    }
}
