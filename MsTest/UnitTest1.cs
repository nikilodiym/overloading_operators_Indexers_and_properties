using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Salary = 1000;
            employee2.Salary = 2000;
            Assert.IsTrue(employee1 < employee2);
        }

        public void TestMethod2()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Salary = 3000;
            employee2.Salary = 4000;
            Assert.IsFalse(employee1 < employee2);
        }
    }

    public class Employee
    {
        public int Salary { get; set; }

        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }

        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }
    }
}