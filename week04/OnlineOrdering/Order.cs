using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0m;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        decimal shippingCost = _customer.IsInUsa() ? 5.00m : 35.00m;
        return total + shippingCost;
    }
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("--- PACKING LABEL ---");
        foreach (Product product in _products)
        {
            label.AppendLine($"Product: {product.GetName()} | ID: {product.GetProductId()}");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("--- SHIPPING LABEL ---");
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddress().GetFormattedAddress());
        return label.ToString();
    }
}