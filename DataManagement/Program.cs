using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using Booking;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookingFinal("OODExam_TristanCawley"))
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Create Customers
                        Customer c1 = new Customer() { Name = "Tom Jones", ContactNumber = "086-123 4567" };
                        Customer c2 = new Customer() { Name = "Mary Smith", ContactNumber = "086 546 3214" };
                        Customer c3 = new Customer() { Name = "Jo Doyle", ContactNumber = "087 1221 222" };

                        //add the customer to the booking
                        db.Customers.Add(c1);
                        db.Customers.Add(c2);
                        db.Customers.Add(c3);

                        // Save changes to the database
                        db.SaveChanges();

                        transaction.Commit();
                        Console.WriteLine("Movies added successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}
