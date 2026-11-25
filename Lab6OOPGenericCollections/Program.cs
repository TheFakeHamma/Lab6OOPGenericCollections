namespace Lab6OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Anas", "Male", 20000);
            Employee emp2 = new Employee(102, "Hanna", "Female", 30000);
            Employee emp3 = new Employee(103, "Tobias", "Male", 40000);
            Employee emp4 = new Employee(104, "Sara", "Female", 40000);
            Employee emp5 = new Employee(105, "Anna", "Female", 50000);

            Stack<Employee> stack = new Stack<Employee>();

            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);

            foreach (Employee emp in stack)
            {
                Console.WriteLine(emp);
                Console.WriteLine("Items left in the Stack = " + stack.Count);
            }
            Console.WriteLine("----------------------------");

            Console.WriteLine("Retrieve Using Pop Method");
            while (stack.Count > 0)
            {
                Employee popped = stack.Pop();
                Console.WriteLine(popped);
                Console.WriteLine("Items left in the Stack = " + stack.Count);
            }
            Console.WriteLine("----------------------------");

            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);

            Console.WriteLine("Retrive using Peek Method");

            Employee peek1 = stack.Peek();
            Console.WriteLine(peek1);
            Console.WriteLine("Items left in the Stack = " + stack.Count);

            Employee peek2 = stack.Peek();
            Console.WriteLine(peek2);
            Console.WriteLine("Items left in the Stack = " + stack.Count);

            Console.WriteLine("----------------------------");

            if (stack.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

            Console.WriteLine("----------------------------");

            List<Employee> list = new List<Employee>();

            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);
            list.Add(emp5);

            if (list.Contains(emp2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Console.WriteLine();

            Employee firstMale = list.Find(g => g.Gender == "Male");
            Console.WriteLine($"ID = {firstMale.Id}, Name = {firstMale.Name}, Gender = {firstMale.Gender}, Salary = {firstMale.Salary}");
            Console.WriteLine();

            List<Employee> allMales = list.FindAll(g => g.Gender == "Male");
            foreach (Employee emp in allMales)
            {
                Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
            }

        }
    }
}
