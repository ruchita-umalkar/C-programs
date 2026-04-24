// REST API with Caching (Redis) 
using System;
using StackExchange.Redis;  
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
