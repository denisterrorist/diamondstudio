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
    /// Логика взаимодействия для slide3.xaml
    /// </summary>
    public partial class slide3 : Page
    {
        public slide3()
        {
            InitializeComponent();
        }

        private void slide3_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new mainpage());
        }
    }
}
