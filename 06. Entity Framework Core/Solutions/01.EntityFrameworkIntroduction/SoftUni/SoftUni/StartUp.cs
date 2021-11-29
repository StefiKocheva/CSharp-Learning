namespace SoftUni
{
    using System;
    using System.Linq;
    using System.Text;
    using SoftUni.Data;
    using SoftUni.Models;

    public static class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(GetDepartmentsWithMoreThan5Employees(new SoftUniContext()));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var sb = new StringBuilder();

            context
                .Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new
                {
                    Name = string.Join(" ", e.FirstName, e.LastName, e.MiddleName),
                    e.JobTitle,
                    e.Salary,
                })
                .ToList()
                .ForEach(e => sb.AppendLine($"{e.Name} {e.JobTitle} {e.Salary:f2}"));

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var sb = new StringBuilder();

            context
                .Employees
                .OrderBy(e => e.FirstName)
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary,
                })
                .ToList()
                .ForEach(e => sb.AppendLine($"{e.FirstName} - {e.Salary:f2}"));

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var sb = new StringBuilder();

            context
                .Employees
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary,
                    Department = e.Department.Name,
                })
                .ToList()
                .ForEach(e => sb.AppendLine($"{e.FirstName} {e.LastName} from {e.Department} - ${e.Salary:f2}"));

            return sb.ToString().TrimEnd();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var address = new Address()
            {
                TownId = 4,
                AddressText = "Vitoshka 15",
            };

            context
                .Employees
                .FirstOrDefault(e => e.LastName == "Nakov")
                .Address = address;

            context.SaveChanges();

            var sb = new StringBuilder();

            context
                .Employees
                .OrderByDescending(e => e.Address.AddressId)
                .Take(10)
                .Select(e => e.Address.AddressText)
                .ToList()
                .ForEach(e => sb.AppendLine(e));

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employees = context
                .Employees
                .Take(10)
                .Where(e => e.EmployeesProjects.Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
                .Select(e => new
                {
                    EmployeeName = string.Join(" ", e.FirstName, e.LastName),
                    ManagerName = string.Join(" ", e.Manager.FirstName, e.Manager.LastName),
                    Projects = e.EmployeesProjects.Select(ep => new
                    {
                        ep.Project.Name,
                        ep.Project.StartDate,
                        ep.Project.EndDate,
                    }),
                })
                .ToList();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.EmployeeName} - Manager: {e.ManagerName}");

                foreach (var p in e.Projects)
                {
                    var name = p.Name;
                    var startDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt");
                    var endDate = p.EndDate.HasValue ? p.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished";

                    sb.AppendLine($"--{name} - {startDate} - {endDate}");
                }
            }
              
            return sb.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var sb = new StringBuilder();

            context
                .Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .ThenBy(a => a.AddressText)
                .Take(10)
                .Select(a => new
                {
                    a.AddressText,
                    TownName = a.Town.Name,
                    EmployeesCount = a.Employees.Count,
                })
                .ToList()
                .ForEach(a => sb.AppendLine($"{a.AddressText}, {a.TownName} - {a.EmployeesCount} employees"));


            return sb.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employees = context
                .Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    Name = string.Join(" ", e.FirstName, e.LastName),
                    JobTitle = e.JobTitle,
                    Projects = e.EmployeesProjects.Select(ep => ep.Project.Name),
                })
                .ToList();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.Name} - {e.JobTitle}");

                foreach (var p in e.Projects)
                {
                    sb.AppendLine(p);
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var employees = context
                .Departments
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Where(d => d.Employees.Count > 5)
                .Select(d => new
                {
                    Department = d.Name,
                    ManagerName = string.Join(" ", d.Manager.FirstName, d.Manager.LastName),
                    Employee = d.Employees.Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.JobTitle,
                    })
                    //.OrderBy(e => e.FirstName)
                    //.ThenBy(e => e.LastName),
                })
                .OrderBy(d => d.Employee.Select(e => e.FirstName))
                .ThenBy(d => d.Employee.Select(e => e.LastName))
                .ToList();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.Department} - {e.ManagerName}");

                foreach (var emp in e.Employee)
                {
                    sb.AppendLine($"{emp.FirstName} {emp.LastName} - {emp.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var sb = new StringBuilder();

            context
                .Projects 
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate,
                })
                .OrderBy(p => p.Name)
                .ToList()
                .ForEach(p => sb.AppendLine(string.Join(Environment.NewLine, p.Name, p.Description, p.StartDate)));

            return sb.ToString().TrimEnd();

        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            context
                .Employees
                .Where(e => e.Department.Name == "Engineering" || e.Department.Name == "Tool Design" || e.Department.Name == "Marketing" || e.Department.Name == "Information Services")
                .ToList()
                .ForEach(e => e.Salary *= 1.12m);

            context.SaveChanges();

            var sb = new StringBuilder();

            context
                .Employees
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Where(e => e.Department.Name == "Engineering" || e.Department.Name == "Tool Design" || e.Department.Name == "Marketing" || e.Department.Name == "Information Services")
                .Select(e => new
                {
                    Name = string.Join(" ", e.FirstName, e.LastName),
                    e.Salary,
                })
                .ToList()
                .ForEach(e => sb.AppendLine($"{e.Name} (${e.Salary:f2})"));

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var sb = new StringBuilder();

            context
                .Employees
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new
                {
                    Name = string.Join(" ", e.FirstName, e.LastName),
                    e.Salary,
                    e.JobTitle,
                })
                .ToList()
                .ForEach(e => sb.AppendLine($"{e.Name} - {e.JobTitle} - (${e.Salary:f2})"));

            return sb.ToString().TrimEnd();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var project = context.Projects.Find(2);

            context
                .EmployeesProjects
                .Where(ep => ep.Project.ProjectId == 2)
                .ToList()
                .ForEach(ep => context.EmployeesProjects.Remove(ep));

            context.Remove(project);

            context
                .Projects
                .Take(10)
                .Select(p => new
                {
                    p.Name
                })
                .ToList()
                .ForEach(p => sb.AppendLine(p.Name));


            return sb.ToString().TrimEnd();
        }

        public static string RemoveTown(SoftUniContext context)
        {
            var townName = "Seattle";

            context
                .Employees
                .Where(e => e.Address.Town.Name == townName)
                .ToList()
                .ForEach(e => e.AddressId = null);

            var count = context
                .Addresses
                .Where(a => a.Town.Name == townName)
                .Count();

            context
                .Addresses
                .Where(a => a.Town.Name == townName)
                .ToList()
                .ForEach(a => context.Addresses.Remove(a));

            context
                .Towns
                .Remove(context
                    .Towns
                    .FirstOrDefault(t => t.Name == townName));

            context.SaveChanges();


            return $"{count} addresses in Seattle were deleted";
        }
    }
}
