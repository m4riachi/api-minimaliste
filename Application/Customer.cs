namespace Application;

// generate all method for CRUD
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    
    public Customer(int id, string name, string email, string phoneNumber)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
    
    // create method to get all customers
    public static Customer[] GetCustomers()
    {
        return new[]
        {
            new Customer(1, "John Doe", "", "1234567890"),
            new Customer(2, "Jane Doe", "", "1234567890")
        };
    }
    
    // create method to get customer by id
    public static Customer GetCustomer(int id)
    {
        return id switch
        {
            1 => new Customer(1, "John Doe", "", "1234567890"),
            2 => new Customer(2, "Jane Doe", "", "1234567890"),
            _ => new Customer(0, "", "", "")
        };
    }
    
    // create method to add customer
    public static Customer AddCustomer(Customer customer)
    {
        return customer;
    }
    
    // create method to update customer
    public static Customer UpdateCustomer(int id, Customer customer)
    {
        return customer;
    }
    
    // create method to delete customer
    public static Customer DeleteCustomer(int id)
    {
        return new Customer(0, "", "", "");
    }

}