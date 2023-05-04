//using MotoApp;

//var stack = new Stack<double>();//w nawiasach <> piszemy jaki typ danych chcemy uzywac

using MotoApp.Repositories;
using MotoApp.Entities;

var employeeRepository = new GenericRepository<Employee, int>();
employeeRepository.Add(new Employee { FirstName = "Konrad" });
employeeRepository.Add(new Employee { FirstName = "Kamil" });
employeeRepository.Add(new Employee { FirstName = "Ela" });
employeeRepository.Add(new Employee());
employeeRepository.Save();
