using Microsoft.AspNetCore.Mvc;
using System.Xml;
using BlazorXml.Shared;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;

namespace BlazorXml.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;

        public EmployeeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            XmlDocument doc = new XmlDocument();
            //doc.Load(string.Concat(_environment.WebRootPath, "/Employee.xml"));
            doc.Load("C:\\Users\\oferm\\source\\repos\\C learning\\תקופת היזמות\\Blazor\\BlazorXml\\BlazorXml\\Client\\wwwroot\\Employee.xml");

            foreach (XmlNode node in doc.SelectNodes("/Employees/Employee"))
            {
                employees.Add(new Employee()
                {
                    Id = int.Parse(node["Id"].InnerText),
                    Name = node["Name"].InnerText,
                    Country = node["Country"].InnerText,
                });
            }

            return employees;
        }
    }
}