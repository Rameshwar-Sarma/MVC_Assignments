using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObservableCollections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Employee> empObj;
        public MainWindow()
        {
            InitializeComponent();
            empObj = new ObservableCollection<Employee>()
            {
                new Employee() {Id = 250 ,Name = "Rameshwar", Role = "Developer", Salary = 23000}
            };
            lstNames.ItemsSource = empObj;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            empObj.Add(new Employee() { Id = Convert.ToInt32(txtId.Text), Name = txtName.Text, Role = txtRole.Text, Salary = Convert.ToInt32(txtSalary.Text) });
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRole.Text = string.Empty;
            txtSalary.Text = string.Empty;

        }
    }
}

