namespace overloading_operators_Indexers_and_properties
{
    public class Task1
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public static Task1 operator +(Task1 employee, decimal amount)
        {
            employee.Salary += amount;
            return employee;
        }

        public static Task1 operator -(Task1 employee, decimal amount)
        {
            employee.Salary -= amount;
            return employee;
        }

        public static bool operator ==(Task1 employee1, Task1 employee2)
        {
            return employee1.Salary == employee2.Salary;
        }

        public static bool operator !=(Task1 employee1, Task1 employee2)
        {
            return employee1.Salary != employee2.Salary;
        }

        public static bool operator >(Task1 employee1, Task1 employee2)
        {
            return employee1.Salary > employee2.Salary;
        }

        public static bool operator <(Task1 employee1, Task1 employee2)
        {
            return employee1.Salary < employee2.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Task1 other = (Task1)obj;
            return Salary == other.Salary;
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
    }
}
