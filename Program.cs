using System;

namespace model_3_things
{
    class Program
    {
        public class House
        {
            public int NumFloors {get; set;}
            public int NumRooms {get; set;}
            public int YearBuilt {get; set;}

            public override string ToString()
            {
                return $"House has {NumFloors} floors and {NumRooms} rooms, and was built in {YearBuilt}.";
            }
        }

        public class Car
        {
            public int ModelYear {get; set;}
            public string Make {get; set;}
            public string Model {get; set;}
            public int Doors {get;set;}
            public int Miles {get; set;}

            public override string ToString()
            {
                return $"Your car is a {ModelYear} {Make} {Model}.  It has {Doors} doors, and the odometer reading is {Miles} miles.";
            }

        }

        public class Hobbies
        {
            public string Hobby1 {get; set;}
            public string Hobby2 {get; set;}
            public string Hobby3 {get; set;}
            public string Hobby4 {get; set;}
            public string Hobby5 {get; set;}
        }

        static void Main(string[] args)
        {
            var house = new House();
            house.NumFloors = 2;
            house.NumRooms = 5;
            house.YearBuilt = 1987;
            Console.WriteLine(house);

            var car = new Car();
            car.ModelYear = 2015;
            car.Make = "Toyota";
            car.Model = "Corolla";
            car.Doors = 4;
            car.Miles = 23333;
            Console.WriteLine(car);

            var hobbies = new Hobbies();
            hobbies.Hobby1 = "Photography";
            hobbies.Hobby2 = "Wildlife watching";
            hobbies.Hobby3 = "Planespotting";
            hobbies.Hobby4 = "Singing";
            hobbies.Hobby5 = "World travel";
            Console.WriteLine($"My hobbies are: {hobbies.Hobby1}, {hobbies.Hobby2}, {hobbies.Hobby3}, {hobbies.Hobby4} and {hobbies.Hobby5}.");
        }
    }
}
