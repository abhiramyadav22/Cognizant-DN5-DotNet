package Deep_Skilling.EngineeringConcepts.DependencyInjectionExample;
interface CustomerRepository
{
    void findCustomer();
}

class CustomerRepositoryImpl
implements CustomerRepository
{
    public void findCustomer()
    {
        System.out.println("Customer Found");
    }
}

class CustomerService
{
    CustomerRepository repository;

    CustomerService(CustomerRepository repository)
    {
        this.repository = repository;
    }

    void getCustomer()
    {
        repository.findCustomer();
    }
}

class Main
{
    public static void main(String args[])
    {
        CustomerRepository repository =
        new CustomerRepositoryImpl();

        CustomerService service =
        new CustomerService(repository);

        service.getCustomer();
    }
}