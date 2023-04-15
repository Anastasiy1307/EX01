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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ADDD.xaml
    /// </summary>
    public partial class ADDD : Page
    {
        List<People> peoples= new List<People> { new People()};
        public Frame frame1;
        public ADDD(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            peoples = PEEntities2.GetContext().People.ToList();
            
        }

        public void ADD() 
        {
           
            peoples[0].FirstName = name.Text;
            peoples[0].Surname = surname.Text;
            peoples[0].id_group = Convert.ToInt32(group.Text);
            peoples[0].id_pol = Convert.ToInt32(pol.Text);
            peoples[0].date_bir = calendar.SelectedDate;
            PEEntities2.GetContext().People.Add(peoples[0]);
            PEEntities2.GetContext().SaveChanges();
            frame1.Navigate(new Glavn(frame1));           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ADD();
        }
    }
}
