using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_s_Panel
{
    abstract class Parent
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public Parent(string Name, string Family, string City, string PhoneNumber, int Age)
        {
            this.Name = Name;
            this.Family = Family;
            this.City = City;
            this.PhoneNumber = PhoneNumber;
            this.Age = Age;
        }

        public abstract void Print();

        public void PrintParentInfo()
        {
            Console.WriteLine("Name:{0}   Family:{1}   City:{2}   PhoneNumber:{3}   Age:{4}",Name,Family,City,PhoneNumber,Age);
            
        }
       

    }
}
