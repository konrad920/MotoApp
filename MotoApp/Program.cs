using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

//var repository = new GenericRepository<Employee>();
//repository.Add(new Employee { FirstName = "Adam" });
//repository.Add(new Employee { FirstName = "Konrad" });
//repository.Add(new Employee { FirstName = "Kamil" });
//repository.Save();

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmployees(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmployees(IRepository<Employee>employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Konrad" });
    employeeRepository.Add(new Employee { FirstName = "Ela" });
    employeeRepository.Add(new Employee { FirstName = "Kamil" });
    employeeRepository.Save();
}

static void AddManagers(IWriteRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Beata" });
    managerRepository.Add(new Manager { FirstName = "Paweł" });
    managerRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var _items = repository.GetAll();
    foreach (var item in _items)
    {
        Console.WriteLine(item);
    }
}

//static void GetEmployeeById(IRepository<Employee> employeeRepository)
//{
//    var employee = employeeRepository.GetById(2);
//    Console.WriteLine(employee.ToString());
//}
