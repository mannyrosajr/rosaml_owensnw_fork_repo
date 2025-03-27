using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosaml_owensnw_fork_repo
{
   /// <summary>
   /// Manny's favorite car 
   /// </summary>
    internal class Car
    {
        private String _name;
        private double _price;

        public double Price { get { return _price; } set { _price = value; } }
        public string Name { get { return _name; } set { _name = value; } }
    }
}
