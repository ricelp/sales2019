﻿
namespace sales2019.Backend.Models
{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Common.Models.Product> Products { get; set; }
    }
}