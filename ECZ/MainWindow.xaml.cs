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

namespace ECZ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        gr693_pdvEntities1 db;
        public MainWindow()
        {
            db = new gr693_pdvEntities1();
            InitializeComponent();
            dgogrenci.ItemsSource = db.Employee.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee();
            emp.First_name = name.Text;
            emp.Last_name = last.Text;
            emp.Middle_name = mid.Text;
            emp.Age = Convert.ToInt32(age.Text);
            emp.Post = post.Text;
            db.Employee.Add(emp);
            db.SaveChanges();
            dgogrenci.ItemsSource = db.Employee.ToList();
        }
    }
}
