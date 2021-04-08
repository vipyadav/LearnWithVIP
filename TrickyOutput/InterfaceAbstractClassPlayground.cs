namespace LearnWithVIP.TrickyOutput
{
    public interface IEmployee
    {
        string GetName();
        string GetSalary();
    }

    public abstract class EmployeeBase : IEmployee
    {
        public abstract string GetName();
        public abstract string GetSalary();
    }
}
