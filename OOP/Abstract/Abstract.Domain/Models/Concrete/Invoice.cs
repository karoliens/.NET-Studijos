using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Domain.Models.Concrete
{
    public class Invoice
    {
        public int PhoneNumber { get; set; }



        public Invoice() { }
        public Invoice(int phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public Invoice(string emailAdd)
        {
            EmailAdd = emailAdd;
        }

        public string EmailAdd { get; set; }
        public string PostAdd { get; set; }
        public DateTime InvoiceDate { get; set; }
        void Send(int phoneNumber, string emailAdd, string postAdd)
        {

        }
    }
}
