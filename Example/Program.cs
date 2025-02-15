namespace Lecture5
{
    interface IMovable
    {
        //int Position { get; }

        void Move(int distance);
    }

    public class Robot : IMovable
    {
        public int Position
        {
            get;
            private set;
        } = 0;

        public void Move(int distance)
        {
            if (distance < 0)
                throw new ArgumentException("Distance can not be <0");
            this.Position += distance;
            Console.WriteLine($"Robot moved {distance} points. Current position: {this.Position}");
        }
        public Robot() { }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            IMovable robot = new Robot();
            robot.Move(10);
            robot.Move(20);
        }
    }
    
}



