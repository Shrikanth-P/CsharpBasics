using System;


/// <summary>
///1. Practice all the below concepts:
/// ->instance and static methods
/// ->Control statements
/// ->enumeration
/// </summary>

namespace CsharpBasics
{
    enum color
    {
        red,
        green,
        blue,
        magenta=5,
        cyan,
        greenyellow
    }
    class Basic
    {
        public static void Main(String []args)
        {
         Basic basic = new Basic();
            basic.method();
            method1();
            controlStatement();
            Console.WriteLine("enum "+color.red);
            Console.WriteLine("enum color green value "+(int)color.green);
            Console.WriteLine("enum color magenta value "+(int)color.magenta);
            Console.WriteLine("enum color cyan value "+(int)color.cyan);

            // calling the employee static method
            emp.empdetails(1, "Shri", 30000);
           
        }
        public void method()
        {
            Console.WriteLine("Instance Method called by object");
        }
        public static void method1()
        {
            Console.WriteLine("static Method no need to create a object directly invokes by method name");
        }
        public static void controlStatement()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the Three number get Largest of three number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine(num1+" is Largest Among three number  ");
                }
            }else if(num2 > num3)
            {
                Console.WriteLine(num2+" is Largest Among three number  ");
            }
            else
            {
                Console.WriteLine(num3+" is Largest Among three number  ");
            }
            int exp = 2;
            switch (exp)
            {
                case 1:
                    Console.WriteLine("Case 1 from Switch Control Statement");
                    break;
                case 2:
                    Console.WriteLine("Case 2 from Switch Control Statement");
                    break;
                case 3:
                    Console.WriteLine("Case 3 from Switch Control Statement");
                    break;
                default: 
                    Console.WriteLine("default Statement invokes expression not matched to any of cases");
                    break;   
            }
            Console.ReadKey();
        }
        ///<summary>
        /// 2. WAP to accept all the employee 
        /// details using static method and display 
        /// details in an instance method:
        /// </summary> 
    }
    class emp
    {
        public int empid;
        public String empname;
        public int empsal;
        
        public static void empdetails(int eid, String ename, int salary)
        {
            emp e1 = new emp();
            e1.empid = eid; 
            e1.empname = ename;
            e1.empsal = salary;     
           // return e1;
            e1.empdetailsdisplay(e1);//calling instances method to display employee details
        }
        public void empdetailsdisplay(emp e1)
        {
            Console.WriteLine("Employee ID : " + e1.empid);
            Console.WriteLine("Employee name : " + e1.empname);
            Console.WriteLine("Employee Salary : " + e1.empsal);
        }
    }
}