namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************WELCOME TO EMPLOYEE WAGE COMPUTATION*****************");
            Console.WriteLine("1.UC1 Employee Attendance");
            Console.WriteLine("2.UC2 Employee PartTime");

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
            }
        }
    }
}