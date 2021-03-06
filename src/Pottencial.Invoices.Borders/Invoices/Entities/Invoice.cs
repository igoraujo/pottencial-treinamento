﻿using System;
using System.Collections.Generic;

namespace Pottencial.Invoices.Borders.Invoices.Entities
{
    public class Invoice
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string Customer { get; set; }

        public Status Status { get; set; }

        public IList<Item> Items { get; set; }
    }
}
