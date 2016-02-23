using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasses
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cars> List = new List<Cars>();
            Cars a = new Cars();
            a.CarName = "BMW";
            a.CarModel = "m4";
            a.CarColor = "white";
            List.Add(a);

            a = new Cars();
            a.CarName = "Citroen";
            a.CarModel = "c1";
            a.CarColor = "Black";
            List.Add(a);
            a.getSetName = List;
            List<Cars> List1 = new List<Cars>();
            Cars b = new Cars();
            b.CarName = "Ford  Harley - Davidson";
            b.CarModel = " F-150";
            b.CarColor = "black";
            List1.Add(b);

            List<Cars> List2 = new List<Cars>();
            Cars c = new Cars();
            c.CarName = "Pagani Zonda";
            c.CarModel = " C12 Roadster";
            c.CarColor = "pink";
            List2.Add(c);

            List<Cars> List3 = new List<Cars>();
            Cars d = new Cars();
            d.CarName = "Salmon P. Chase";
            d.CarModel = " Triumph TR6 ";
            d.CarColor = "rruset brown";
            List3.Add(d);
            List3.Add(a);
            List<Cars> List4 = new List<Cars>();
            Cars e = new Cars();
            e.CarName = "Mercedes";
            e.CarModel = " E Class ";
            e.CarColor = "gold";
            List4.Add(b);
            List4.Add(e);
            var p1 = new Person( "Peter" , "Gould");

            p1.GetSetCar = a.getSetName;
            p1.Print();
            Console.ReadLine();


            Person p2 = new Person("Moira"," Walley");
            p2.GetSetCar = List1;
            p2.Print();
            Console.ReadLine();

          var p3 = new Person("David", "Mastras");
            p3.GetSetCar = List3;
            p3.Print();
            Console.ReadLine();
            var p4 = new Person("John " , "Shiban");
            p4.GetSetCar = List4;
            p4.Print();
            Console.ReadLine();
           var p5 = new Person("Samanta" , "Catlin");
            p5.GetSetCar = List2;
            p5.Print();
            Console.ReadLine();
            
        }
    }
}
