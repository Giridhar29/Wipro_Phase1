namespace ocp;
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }



    public Employee()
    {

    }

    public Employee(int id, string name)
    {
        this.Id = id;
        this.Name = name;

    }

    public override string ToString()
    {
        return string.Format($"Employee Id is : {Id} and Name : {Name}");
    }

}