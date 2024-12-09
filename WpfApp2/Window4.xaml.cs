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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            DeviceStatusSnippetPopup.IsOpen = true;
        }

        private void Popup_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!OpenPopupBorder.IsMouseOver)
                DeviceStatusSnippetPopup.IsOpen = false;
        }


        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!DeviceStatusSnippetPopup.IsMouseOver)
                DeviceStatusSnippetPopup.IsOpen = false;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Privet");
        }
    }
}
