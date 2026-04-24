// REST API with Entity Framework Core 
using System;
using System.Collections.Generic;   
using Microsoft.EntityFrameworkCore;
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}