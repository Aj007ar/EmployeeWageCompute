namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************WELCOME TO EMPLOYEE WAGE COMPUTATION*****************");
            Console.WriteLine("1.UC1 Employee Attendance");
            Console.WriteLine("2.UC2 Employee PartTime");
            Console.WriteLine("3.UC3 Employee DailyWage");
            Console.WriteLine("4.UC4 Employee Wage using Switch");
            Console.WriteLine("5.UC5 Employee Wage for a Month");
            Console.WriteLine("5.UC5 Employee Wage for a Month");
            Console.WriteLine("6.UC6 Employee Wage using while");

            Console.WriteLine("\nEnter number for UC execute");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    Console.WriteLine("\n***************Employee Attendance***************************");
                    UC1EmplyeeAttendance emplyeeAttendance = new UC1EmplyeeAttendance();
                    emplyeeAttendance.CheckAttendance();
                    break;
                case 2:
                    Console.WriteLine("\n*****************Part_Time/Full_Time Wage*********************");
                    UC2PartTime partTime = new UC2PartTime();
                    partTime.PartTimeWage();
                    break;
                case 3:
                    Console.WriteLine("\n*****************Employee Wage*******************************");
                    UC3EmployeeWage wage = new UC3EmployeeWage();
                    wage.DailyWage();
                    break;
                case 4:
                    Console.WriteLine("\n*************Epmloyee wage using Switch Case*******************");
                    UC4EmpWageSwitch wageCase = new UC4EmpWageSwitch();
                    wageCase.Empwage();
                    break;
                case 5:
                    Console.WriteLine("\n**************Total Salary For Month****************************");
                    UC5EmpWageMonth totalWage = new UC5EmpWageMonth();
                    totalWage.EmpWageMonth();
                    break;
                case 6:
                    Console.WriteLine("\n***************Max Salary using While****************************");
                    UC6EmpWageWhile obj1 = new UC6EmpWageWhile();
                    obj1.EmpWageTotal();
                    break;
            }
        }
    }
}