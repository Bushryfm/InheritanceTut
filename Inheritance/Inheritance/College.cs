using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class College
    {
        string CollegeName = "National college";
       internal string PrincipalName = "Bushry";

        public void ReplaceMethod() 
        {
            Console.WriteLine("The College Name Is " + CollegeName);
            Console.WriteLine("The Pricipal Name Is " + PrincipalName);

        }

    }

   internal class Department :College
    {
       public String DepartmentName = "Science";
        public String SubDepartmentName = "SpaceScience";

        public void DefaultMethod()
        {
            Console.WriteLine("The Department Name is " + DepartmentName);
            Console.WriteLine("The Sub Department name is " + SubDepartmentName);
            Console.WriteLine("The Principal name is " + PrincipalName);

        }
    }



}
