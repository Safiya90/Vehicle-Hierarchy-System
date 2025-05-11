namespace Vehicle_Hierarchy_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Camery", 2024, 4);
            Truck truck1 = new Truck("Nisan", "Altima", 2018, 18.5);

            car1.DisplayInfo();
            truck1.DisplayInfo();
        }
    }
    class Vehicle
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }

    }
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doors: {NumberOfDoors}");
        }
    }
    class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        public Truck(string make, string model, int year, double loadCapacity)
            : base(make, model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Load Capacity: {LoadCapacity}");
        }
    }
}
