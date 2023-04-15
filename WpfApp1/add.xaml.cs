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
    /// Логика взаимодействия для add.xaml
    /// </summary>
    public partial class add : Page
    {
        public Frame frame1;
        List<People> people = new List<People> { new People() };
        object oo;
        public add(Frame frame, object ook)
        {
            oo = ook;
            frame1 = frame;
            InitializeComponent();
            people[0] = (People)oo;
            name.Text = people[0].FirstName;
            surname.Text = people[0].Surname;
            group.Text = people[0].id_group.ToString();
            pol.Text = people[0].id_pol.ToString();
            calendar.SelectedDate = people[0].date_bir;
            calendar.DisplayDate = (DateTime)people[0].date_bir;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<People> people1 = new List<People> ();
            people1 = PEEntities2.GetContext().People.ToList();
            for (int i = 0; i < people1.Count; i++)
            {
                if (people1[i].ID == people[0].ID)
                {
                    people1[i].FirstName = name.Text;
                     people1[i].Surname = surname.Text ;
                    people1[i].id_group =Convert.ToInt32( group.Text);
                    people1[i].id_pol = Convert.ToInt32(pol.Text);
                    people1[i].date_bir = calendar.SelectedDate;
                    PEEntities2.GetContext().SaveChanges();
                    frame1.Navigate(new Glavn(frame1));
                    break;
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<People> peoples2= new List<People> ();
            peoples2 = PEEntities2.GetContext().People.ToList();

            for (int i = 0; i < peoples2.Count; i++)
            {

                if (peoples2[i].ID == people[0].ID)
                {
                    PEEntities2.GetContext().People.Remove(peoples2[i]);
                    PEEntities2.GetContext().SaveChanges();
                    frame1.Navigate(new Glavn(frame1));
                    break;
                }

            }

        }
    }
}
