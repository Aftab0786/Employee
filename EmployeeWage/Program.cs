using EmployeeWage;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Employee Wage Problems....");
        EmployeWageComputation employee = new EmployeWageComputation();
        // employee.Attendence();
        //employee.DailyWage();
        // employee.PartTime();
        //employee.SwitchCase();
        //employee.MonthlyWage();
        EmployeWageComputation.ComputeEmployeWageComputation("Prinston", 20,20,100);
        EmployeWageComputation.ComputeEmployeWageComputation("Flipkart", 40,15,200);
        EmployeWageComputation.ComputeEmployeWageComputation("Amazon", 30,20,100);




    }
}
    

