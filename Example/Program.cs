namespace Lecture5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            Manager mgr = new Manager();
            Developer dev = new Developer();

            Console.WriteLine("Calling DisplayInfo() on direct instances:");
            emp.DisplayInfo();
            mgr.DisplayInfo();
            dev.DisplayInfo();

            Console.WriteLine("\nCalling DisplayInfo() on a Manager stored as an Employee reference:");
            Employee empRef = mgr;
            empRef.DisplayInfo();
            Console.WriteLine("\nCalling DisplayInfo() on a Developer stored as an Employee reference:");
            Employee devRef = dev;
            devRef.DisplayInfo();
        }
    }
    
}



