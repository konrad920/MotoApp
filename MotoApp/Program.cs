using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

//var repository = new GenericRepository<Employee>();
//repository.Add(new Employee { FirstName = "Adam" });
//repository.Add(new Employee { FirstName = "Konrad" });
//repository.Add(new Employee { FirstName = "Kamil" });
//repository.Save();

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
employeeRepository.Add(new Employee { FirstName = "Konrad"});
employeeRepository.Add(new Employee { FirstName = "Ela" });
employeeRepository.Add(new Employee { FirstName = "Kamil" });
employeeRepository.Save();

GetEmployeeById(employeeRepository);

static void GetEmployeeById(IReadRepository<IEntity> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine(employee.ToString());
}
