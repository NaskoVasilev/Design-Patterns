﻿namespace EmployeeAdministration
{
    using System;
    using System.Collections.Generic;

    using EmployeeAdministration.ElementModels;
    using EmployeeAdministration.VisitorModels;
    using Visitor.Common;

    public class Program
    {
        public static void Main()
        {
            var employees = new List<Employee>
            {
                new Clerk("Peter"),
                new Director("Nasko"),
                new President("Georgi")
            };

            foreach (var employee in employees)
            {
                var employeeType = employee.GetType().Name;
                Console.WriteLine(PrintMessages.VacationDays, employeeType, employee.VacationDays);
                Console.WriteLine(PrintMessages.Income, employeeType, employee.Income);
            }

            Console.WriteLine(PrintMessages.VisitingEmployees, nameof(IncomeVisitor), nameof(VacationVisitor));

            foreach (var employee in employees)
            {
                employee.Accept(new IncomeVisitor());
                employee.Accept(new VacationVisitor());
            }
        }
    }
}
