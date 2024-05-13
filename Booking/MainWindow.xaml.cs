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

using static Booking.BookingFinal;
namespace May2024Exam
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

        private void lbx_BookingDetailsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedBooking = lbx_BookingDetailsList.SelectedItem as Customer;
            if(selectedBooking != null)
            {
                var 
            }
        }

        private void DatePickerBookingDetail_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedBooking = lbx_BookingDetailsList.SelectedItem as Customer;
            if(selectedBooking != null && DatePickerBookingDetail.SelectedDate.HasValue)
            {
                var selectedDate = DatePickerBookingDetail.SelectedDate.Value.Date;
                var booking = db.Bookings.FirstOrDefault(b => BookingDate.Date == selectedDate);
                if(booking != null)
                {
                    tbx_Capacity.Text = 
                }
            }
        }
    }
}
