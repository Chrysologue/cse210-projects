using System;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public double GetOrderTotalCost()
    {
        double totalCost = 0.0;
        foreach(var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost;
    }
    public double GetTotalPrice()
    {
        double shippingCost = (_customer.DoLiveInUSA() == true) ? 5.00 : 35.00;
        double result = shippingCost + GetOrderTotalCost();
        return Math.Round(result, 2);
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(var prod in _products)
        {
            packingLabel += $"Poduct: {prod.Name} - ID: {prod.ProductId}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Name: {_customer.Name}\n{_customer.GetCustomerAddress()}";
    }
}