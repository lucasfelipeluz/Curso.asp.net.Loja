using System;
using Loja.Models.Enums;

namespace Loja.Models
{
    public class SalesRecords
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
        public DateTime Date { get; internal set; }

        public SalesRecords()
        {
        }

        public SalesRecords(int id, DateTime time, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Time = time;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
