using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal _totalCost = 0;
        foreach (Product product in _products)
        {
            _totalCost += product.price * product.quantity;
        }

        decimal shippingCost = _customer.address.IsInUSA() ? 5 : 35;
        _totalCost += shippingCost;

        return _totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.name} - {product.productId}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string _shippingLabel = "Shipping Label:\n";
        _shippingLabel += $"Customer: {_customer.name}\n";
        _shippingLabel += _customer.address.GetFullAddress();

        return _shippingLabel;
    }
}