public class Order {
    private List<Product> _products = new List<Product>();
    private string _customerName;
    private double _totalPrice;
    private Address _destination;

    public Order(string customerName, Address destination) {
        _customerName = customerName;
        _totalPrice = 0;
        _destination = destination;
    }

    public void AddToProductList(Product product) {
        _products.Add(product);
    }

    public double GetTotalPrice() {
        foreach (Product product in _products) {
            _totalPrice += product.GetPriceForProduct();
        }

        _totalPrice += GetShippingCost();

        return _totalPrice;
    }

    public void DisplayPackingLabel() {
        string packingLabel = $@"Packing Label
==============================";
        Console.WriteLine(packingLabel);

        foreach (Product product in _products) {
            string productDetails = product.GetProductDetails();
            Console.WriteLine(productDetails);
        }
    }

    public string GetShippingLabel() {
        string shippingLabel = $@"Shipping Label
==============================
{_customerName}
{_destination.GetFullAddress()}";

        return shippingLabel;
    }

    public int GetShippingCost() {
        int shippingCost;

        if (_destination.IsUSA()) {
            shippingCost = 5;
        }
        else {
            shippingCost = 35;
        }

        return shippingCost;
    }
}