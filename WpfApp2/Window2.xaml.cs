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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        BitmapImage myBitmapImage = new BitmapImage();
        
        public Window2()
        {
            InitializeComponent();
            myBitmapImage.BeginInit();
        }

        

        private void Radiobnt1_Checked(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\KorbachevIV\Downloads\2131231.png"));
        }

        private void Radiobnt2_Checked(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\KorbachevIV\Downloads\2024-10-30_14-34-13.png"));
        }

        private void Radiobnt3_Checked(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\KorbachevIV\Downloads\2024-10-30_14-29-57.png"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
