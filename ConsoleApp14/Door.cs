using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Door:IPart
    {
        public string Create()
        {
            string str = "|  []  |";
            return str;
        }
    }
}
