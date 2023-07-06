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

    public int ShippingCost()
    {
        if (_customer.InUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public int TotalCost()
    {
        int cost = 0;
        foreach (Product product in _products)
        {
            cost += product.TotalPrice();
        }
        return cost + ShippingCost();
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"\n{product.GetName()} - Id:{product.GetId()}";
        }
        return label;
    }

    public string ShippingLabel()
    {
        Address address = _customer.GetAddress();
        return $"\n{_customer.GetName()}\n{address.Display()}";
    }
}