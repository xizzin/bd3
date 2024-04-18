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
using bd3.ITCompany1DataSetTableAdapters;

namespace bd3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeesTableAdapter Employees = new EmployeesTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            EmployeesMainGrid.ItemsSource = Employees.GetDataBy();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeesMainGrid.Columns[0].Visibility = Visibility.Collapsed;
            EmployeesMainGrid.Columns[5].Visibility = Visibility.Collapsed;
            EmployeesMainGrid.Columns[9].Visibility = Visibility.Collapsed;
        }
    }
}