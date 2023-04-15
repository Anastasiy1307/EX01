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
    /// Логика взаимодействия для Avt.xaml
    /// </summary>
    public partial class Avt : Page
    {
        public Frame frame1;
        List<Kod_podrazdel> kod_p = new List<Kod_podrazdel>();

        public Avt(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            kod_p = PEEntities2.GetContext().Kod_podrazdel.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < kod_p.Count; i++)
            {
                if (Podrapdel.Text == kod_p[i].Kodpodrazdel)
                {
                    frame1.Navigate(new Glavn(frame1));
                }
                else
                {
                    MessageBox.Show("Код подразделения не верен", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
            }

            
        }

        private void Podrapdel_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Podrapdel_Copy.Visibility = Visibility.Hidden;
        }
    }
}
