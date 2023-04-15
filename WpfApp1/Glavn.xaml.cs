using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Glavn.xaml
    /// </summary>
    public partial class Glavn : Page
    {
        List<People> peoples= new List<People>();
        public Frame frame1;

        public Glavn(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            peoples = PEEntities2.GetContext().People.ToList();
            listView1.ItemsSource = peoples;
        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        public void Update() 
        {
            var sotr = PEEntities2.GetContext().People.ToList();
            sotr = sotr.Where(p => p.FirstName.ToLower().Contains(Poisk.Text.ToLower())).ToList();
            listView1.ItemsSource = sotr;
        }

        private async void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(100);
            object ldfj = listView1.SelectedItem;
            frame1.Navigate(new add(frame1, ldfj));
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new ADDD(frame1));
        }
    }
    
}
