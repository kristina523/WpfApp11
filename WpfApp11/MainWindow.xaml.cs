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
using WpfApp11.BooksDataSetTableAdapters;
using static WpfApp11.BooksDataSet;

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        BooksTableAdapter books = new BooksTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            BooksGrid.ItemsSource = books.GetDat(); 
        }

        private void window(object sender, RoutedEventArgs e)
        {
            BooksGrid.Columns[0].Visibility = Visibility.Collapsed;
            BooksGrid.Columns[2].Visibility = Visibility.Collapsed;
        }
    }
     
}