using MotoApp.Entities;
using MotoApp.Repositories;

var repository = new GenericRepository<Employee>();
repository.Add(new Employee { FirstName = "Adam" });
repository.Add(new Employee { FirstName = "Konrad" });
repository.Add(new Employee { FirstName = "Kamil" });

repository.Save();

