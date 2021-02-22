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
using Lab7;

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TicketMersedes TickestMersedes = new TicketMersedes();
        public List<TicketMersedes> MersList = new List<TicketMersedes>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesGomelBobruisk(120));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void GJ_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesGomelJlobin(100));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void GS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesGomelSvetlogorsk(80));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesGomelRechica(50));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void RB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesRechicaBobruisk(90));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void RJ_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesRechicaJlobin(70));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void RS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesRechicaSvetlogorsk(40));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void SB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesSvetlogorskBobruisk(80));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void SJ_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesSvetlogorskJlobin(30));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }

        private void JB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MersList.Add(new TicketMersedesJlobinBobruisk(50));
            }
            catch
            {
                MessageBox.Show("Ошибка! Недостаточно мест.");
            }
            ListView.ItemsSource = null;
            ListView.ItemsSource = MersList;
        }
    }
}
