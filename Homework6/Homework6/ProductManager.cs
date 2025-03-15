using System;
using System.Collections.Generic;
using System.Linq;

public class ProductManager
{
    private static List<Product> products = new List<Product>();

    public void Add() => products.Add(new Product
    {
        Id = int.Parse(Console.ReadLine()),
        Name = Console.ReadLine(),
        Price = double.Parse(Console.ReadLine()),
        Quantity = int.Parse(Console.ReadLine())
    });

    public void Display() => products.ForEach(p => Console.WriteLine(p));

    public void Search(string name) => products.Where(p => p.Name.ToLower().Contains(name.ToLower()))
        .ToList().ForEach(p => Console.WriteLine(p));

    public void Delete(int id) => products.Remove(products.FirstOrDefault(p => p.Id == id));

    public void Sort() => products = products.OrderBy(p => p.Price).ToList();

    public void Edit(int id)
    {
        var p = products.FirstOrDefault(p => p.Id == id);
        if (p != null)
        {
            p.Name = Console.ReadLine();
            p.Price = double.Parse(Console.ReadLine());
            p.Quantity = int.Parse(Console.ReadLine());
        }
    }

    public bool IsEmpty() => products.Count == 0;
}