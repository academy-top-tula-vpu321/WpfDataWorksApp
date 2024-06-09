using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDataWorksApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        //public Employee Employee { get; set; }
        //public ObservableCollection<Employee> Employees { get; set; } = new()
        //{
        //    new(){ Name = "Bobby", Age = 25, Avatar = "D:/avatars/avatar1.png" },
        //    new(){ Name = "Anny", Age = 31, Avatar = "D:/avatars/avatar2.jpg" },
        //    new(){ Name = "Tommy", Age = 36, Avatar = "D:/avatars/avatar3.png" },
        //};

        ObservableCollection<Node> nodes = new()
        {
            new()
            {
                   Name  = "Item 1",
                   Nodes = new()
                    {
                        new(){ Name = "Item 1 1" },
                        new(){ Name = "Item 1 2",
                               Nodes = new()
                               {
                                   new(){ Name = "Item 1 2 1" },
                                   new(){ Name = "Item 1 2 2" }
                               }
                             },
                        new(){ Name = "Item 1 2" }
                    }
            },
            new()
            {
                   Name  = "Item 2",
                   Nodes = new()
                    {
                        new(){ Name = "Item 2 1" },
                        new(){ Name = "Item 2 2",
                               Nodes = new()
                               {
                                   new(){ Name = "Item 2 2 1" },
                                   new(){ Name = "Item 2 2 2" }
                               }
                             },
                        new(){ Name = "Item 2 2" }
                    }
            }
        };


        public MainWindow()
        {
            InitializeComponent();

            treeNodes.ItemsSource = nodes;
        }

        void DataContextExample()
        {
            //Employee bob = new() 
            //{ 
            //    Name = "Bobby", 
            //    Age = 28,
            //    Company = new() { Title = "Yandex" }
            //};

            //Employees.Add(bob);


            //lstEmployees.ItemsSource = Employees;

            //this.DataContext = bob;
        }

        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    Employee employee = new();
        //    employee.Name = txtName.Text;
        //    employee.Age = Int32.Parse(txtAge.Text);

        //    Employees.Add(employee);

        //    txtName.Text = "";
        //    txtAge.Text = "";
        //}
    }
}