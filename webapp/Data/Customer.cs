using System;
using System.Collections.Generic;

namespace DevOpsForAzureSQL.Data
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? City { get; set; }
    }
}
