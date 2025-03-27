using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosaml_owensnw_fork_repo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Price = 275000;  
            myCar.Name = "Lamborgini Urus";
            Console.WriteLine("The name of the car is " + myCar.Name);
            Console.WriteLine("Price of my Car is " + myCar.Price); 
            
        }
    }
}
