namespace Lecture5;
public class Employee
    {
        public virtual void DisplayInfo() {
            Console.WriteLine($"{this.GetType().Name}: general information");
        }
    }

    public class Manager : Employee
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"{this.GetType().Name}: specialized information");
        }
    }
class Developer : Employee
{

}

