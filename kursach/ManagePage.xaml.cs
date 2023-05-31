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

namespace kursach
{
    /// <summary>
    /// Логика взаимодействия для ManagePage.xaml
    /// </summary>
    public partial class ManagePage : Page
    {
        public ManagePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MaimFrame.Navigate(new EditPage(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MaimFrame.Navigate(new EditPage((sender as Button).DataContext as rezerv));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MaimFrame.Navigate(new EditPage(null));
        }



    }
}
