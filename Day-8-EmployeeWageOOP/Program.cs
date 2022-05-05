// See https://aka.ms/new-console-template for more information

using Day_8_EmployeeWageOOP;
using static Day_8_EmployeeWageOOP.CompanyEmpWageBuilder;

Console.WriteLine("----- Welcome to Employee Wage Monitoring System -----\n");

CompanyEmpWageBuilder obj = new CompanyEmpWageBuilder();
obj.EmpCheck("Dmart");
obj.EmpCheck("Amazon");

Console.ReadKey();

