using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TPS.Data.Products
{
    public class Perishable : ProductBase
    {
        public int PerishableId { get; set; }

        public DateTimeOffset ManufacturingDate { get; set; }

        public DateTimeOffset ExpiryDate { get; set; }
    }
}