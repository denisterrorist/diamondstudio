using diamondstudio.Core;
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

namespace diamondstudio.pages
{
    /// <summary>
    /// Логика взаимодействия для slide2.xaml
    /// </summary>
    public partial class slide2 : Page
    {
        public slide2()
        {
            InitializeComponent();
        }

        private void slide2_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new slide3());
        }
    }
}
