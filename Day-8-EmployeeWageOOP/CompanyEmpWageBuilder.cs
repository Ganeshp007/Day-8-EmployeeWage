using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_EmployeeWageOOP
{
    internal class CompanyEmpWageBuilder : IEmpOps
    {
            public const int IS_Parttime = 1;
            public const int IS_FUlltime = 2;

            public void EmpCheck(string Company)
            { 
                  
                    Random r = new Random();
                    int empcheck = r.Next(0, 3);

                    switch (empcheck)
                    {
                        case IS_FUlltime: Console.WriteLine("\nEmployee of "+Company+" is Present and it is Fulltime Employee....");
                                           break;

                        case IS_Parttime:  Console.WriteLine("\nEmployee of "+Company+"Present and it is Parttime Employee....");
                                           break;

                        default: Console.WriteLine("\nEmployee of "+Company+" Absent....");
                                    break;
                    }
                    
                
               
            }



        
    }
}
