public class Product {
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity) {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetPriceForProduct() {
        double price = _price * _quantity;
        
        return price;
    }

    public string GetProductDetails() {
        string productDetails = $"{_productID} - {_name} - {_quantity}";

        return productDetails;
    }
}