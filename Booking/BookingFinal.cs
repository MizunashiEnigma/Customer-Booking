using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfParticipants { get; set; }

        public virtual Customer Customer { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public Customer()
        {
            Bookings = new List<Booking>();
        }
      
    }
    public class BookingFinal : DbContext
    {
        public BookingFinal(string dbName) : base() { }

        public BookingFinal() : this("OODExam_TristanCawley") { }

        public DbSet<Booking> Bookings { get; set;}
        public DbSet<Customer> Customers { get; set; }
    }

}
