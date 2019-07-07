using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companyEmployee = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] text = Console.ReadLine()
                    .Replace(" ", "")
                    .Split("->")
                    .ToArray();

                string companyName = text[0];
                if (companyName == "End")
                {
                    break;
                }

                string employeeId = text[1];
                if (!(companyEmployee.ContainsKey(companyName)))
                {
                    companyEmployee[companyName] = new List<string>();
                    companyEmployee[companyName].Add(employeeId);
                }
                else
                {
                    if (!(companyEmployee[companyName].Contains(employeeId)))
                    {
                        companyEmployee[companyName].Add(employeeId);
                    }
                }
            }

            foreach (var company in companyEmployee.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
