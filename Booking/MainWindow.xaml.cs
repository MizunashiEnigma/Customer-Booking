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

namespace Booking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookingFinal db;
        public MainWindow()
        {
            InitializeComponent();
            db = new BookingFinal();
            LoadBooking();
        }

        private void LoadBooking()
        {
            try
            {
                var bookings = db.Bookings.ToList();
                lbx_BookingDetailsList.ItemsSource = bookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Displaying Customer Bookings : " + ex.Message);
            }
        }

    }
}
