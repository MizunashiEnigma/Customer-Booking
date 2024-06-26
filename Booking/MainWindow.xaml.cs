﻿using System;
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

using static May2024Exam.BookingFinal;
using May2024Exam;
using Booking;
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
                lbx_BookingDetailsList.ItemsSource = bookings.ToString();
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
            }
        }

        private void DatePickerBookingDetail_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedBooking = lbx_BookingDetailsList.SelectedItem as Customer;
            if(selectedBooking != null && DatePickerBookingDetail.SelectedDate.HasValue)
            {
                var selectedDate = DatePickerBookingDetail.SelectedDate.Value.Date;
                var booking = db.Bookings;
                if(booking != null)
                {
                }
            }
        }

        private void btn_CustomerSearch_Click(object sender, RoutedEventArgs e)
        {
            var addBooking = new CustomerSearchResults(); //intialize the customersearchresult
            addBooking.Closed += AddBooking_Closed;
            addBooking.Show();

        }

        private void AddBooking_Closed(object sender, EventArgs e)
        {
            LoadBooking(); // Refresh the list of properties when AddBooking is closed
        }
    }
}
