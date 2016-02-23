using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasses
{
    class Person
    {
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            //this.cname = cars;
        }
        public Person(string FirstName, string LastName, List<Cars> cars)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.cname = cars;
        }

        List<Cars> cname = new List<Cars>();

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Cars> GetSetCar
        {
            set { cname = value; }
            get
            {
                return cname;
            }

        }


        public void Print()
        {
            Console.WriteLine("First Name: " + this.FirstName);
            Console.WriteLine("Last Name: " + this.LastName);
            Console.WriteLine(" Owns:-");
            foreach (Cars c in this.GetSetCar)
            {
                Console.WriteLine("Car Name : " + c.CarName + ",  model:" + c.CarModel + " and has colour  " + c.CarColor);

            }

        }

    }

    class Cars
    {

        public List<Cars> getSetName { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
    }
}
