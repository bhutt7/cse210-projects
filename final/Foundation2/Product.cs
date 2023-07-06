public class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _qty;

    public Product(string name, int id, int price, int qty)
    {
        _name =name;
        _id = id;
        _price = price;
        _qty = qty;
    }

    public int TotalPrice()
    {
        return _price * _qty;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }
}