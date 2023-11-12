using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers_Encapsulation.Models
{
    public class Test:Car 
    {
        public void Demo()
        {
            Name = "Undefined";//<= public inheritance da el chatandir
            Model = "none";// <= protected inheritance el chatandi
            _year = 1998; //<= private inheritance el chatan deyil
        }
    }

}
