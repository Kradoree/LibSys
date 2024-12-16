using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public required string Title { get; set; }

        [MaxLength(100)]
        public required string Author { get; set; }

        [MaxLength(100)]
        public required string Category { get; set; }

        public int YearOfPublication { get; set; }

        [MaxLength(100)]
        public required string Status { get; set; }
    }

    public class Reader
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public required string FirstName { get; set; }

        [MaxLength(100)]
        public required string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [MaxLength(100)]
        public required string Address { get; set; }

        [MaxLength(9)]
        public required string PhoneNumber { get; set; }

        [MaxLength(100)]
        public required string Email { get; set; }
        
        public ICollection<Loan>? Loans { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }

    public class Loan
    {
        [Key]
        public int Id { get; set; }

        public Reader? Reader { get; set; }

        public Book? Book { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime ReturnDate { get; set; }

    }

    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public Reader? Reader { get; set; }

        public Book? Book { get; set; }

        public DateTime ReservationDate { get; set; }

        public DateTime AvailabilityDate { get; set; }
    }

    public class Fee
    {
        [Key]
        public int Id { get; set; }

        public Loan? Loan { get; set; }

        [Precision (4,2)]
        public decimal Amount { get; set; }

        public DateTime FeeDate { get; set; }

    }
}



