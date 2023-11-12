using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_Encapsulation.Models
{
    public class Car //<= all class
    {
        public string Name;//<= fields yaziriq
        protected string Model;//<= fields yaziriq
        private int _year; //<=field yaziriq
        public Car()
        {
            
        }
        public Car(string name, string model,int year)
        {
            Name = name; //<= public classin daxilinde el chatandir
            Model = model;//<= protected classin daxilinde el chatandir
            _year = year;//<= private classin daxilinde el chatandir
        }
        public void PublicTest() {
            Console.WriteLine($"<= methods da yaza bilirik");
        }
        protected void ProtectedTest()
        {
            Console.WriteLine("<= methods da yaza bilerik");
        }
        private void PrivateTest()
        {
            Console.WriteLine("<= methods da yaza bilerik");
        }
    }
    
}
