public class Customer {
    private string _name;
    private Address _address;

    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    public string GetCustomerName() {
        return _name;
    }

    public bool IsUSA() {
        if (_address.IsUSA()) {
            return true;
        }
        else {
            return false;
        }
    }
}