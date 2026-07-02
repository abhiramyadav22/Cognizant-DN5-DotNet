class Employee
{
    int id;

    String name;

    Employee(int id,String name)
    {
        this.id = id;

        this.name = name;
    }
}

class EmployeeManagement
{
    public static void main(String args[])
    {
        Employee arr[] =
        new Employee[2];

        arr[0] =
        new Employee(1,"Abhi");

        arr[1] =
        new Employee(2,"Rahul");

        for(Employee e : arr)
        {
            System.out.println(e.name);
        }
    }
}