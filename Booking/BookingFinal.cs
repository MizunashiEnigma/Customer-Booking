using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2024Exam
{
    public class Bookings
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfParticipants { get; set; }

        //booking has one customer
        public virtual Customer Customer { get; set; }


    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        //customer has many bookings
        public ICollection<Bookings> Bookings { get; set; }

        public Customer()
        {
            Bookings = new List<Bookings>();
        }
        public override string ToString()
        {
            return $"{Name} ({ContactNumber}) - Party of {Bookings}";
        }

    }
    public class BookingFinal : DbContext
    {
        public BookingFinal(string dbName) : base() { }

        public BookingFinal() : this("OODExam_TristanCawley") { }

        public DbSet<Bookings> Bookings { get; set;}
        public DbSet<Customer> Customers { get; set; }
    }

}
