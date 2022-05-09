namespace Vehicle_Family
{
    class Vehicle
    {
        public double distance = 0.0;
        public double hour = 0.0;
        public double fuel = 0.0;

        public Vehicle(double distance, double hour, double fuel)
        {
            this.distance = distance;
            this.hour = hour;
            this.fuel = fuel;
        }

        public double Average()
        {
            double average = 0.0;
            average = distance / fuel;
            return average;
        }

        public virtual double Speed()
        {
            double speed = 0.0;
            speed = distance / hour;
            return speed;
        }
    }

    class Car : Vehicle
    {
        public Car(double distance, double hour, double fuel) : base(distance, hour, fuel)
        {
        }
        public override double Speed()
        {
            double speed = 0.0;
            speed = distance / 1.6 / hour;
            return speed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double distance, hour, fuel = 0.0;
            Console.WriteLine("Enter the Distance in KM");
            distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hours");
            hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Fuel");
            fuel = double.Parse(Console.ReadLine());

            Vehicle Veh = new Vehicle(distance, hour, fuel);
            Console.WriteLine($"Car Average is {Veh.Average} KM");
            Console.WriteLine($"Car Speed is {Veh.Speed()} KM/H");

            Console.WriteLine("___________________________________");

            Car C = new Car(distance, hour, fuel);
            Console.WriteLine($"Car Average is {C.Average} Mile");
            Console.WriteLine($"Car Speed is {C.Speed()} Mile/H");
        }
    }
}
