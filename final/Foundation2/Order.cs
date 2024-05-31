public class Order {
    private List<Product> _products = new List<Product>();
    private string _customerName;
    private double _totalPrice;
    private Address _destination;

    public Order(string customerName, Address destination) {
        _customerName = customerName;
        _destination = destination;
    }

    public double GetTotalPrice() {
        return 0;
    }

    public string GetPackingLabel() {
        return "";
    }

    public string GetShippingLabel() {
        return "";
    }

    public int GetShippingCost() {
        return 0;
    }
}