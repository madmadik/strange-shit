using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPart> all = new List<IPart>();
            IWorker allWorkers = new Team();
            IPart basement=null;
            IPart walls = null;
            IPart walls2 = null;
            IPart house=null;
            IPart door = null;
            IPart roof = null;
            while (!all.Contains(house))
            {
                if(!all.Contains(basement))
                {
                    basement = new Basement();
                    all.Add(basement);
                }
                if (!all.Contains(walls))
                {
                     walls = new Walls();
                    all.Add(walls);
                }
                if (!all.Contains(walls2))
                {
                    walls2 = new Walls();
                    all.Add(walls2);
                }
                if (!all.Contains(door))
                {
                    door = new Door();
                    all.Add(door);
                }
                if (!all.Contains(roof))
                {
                    roof = new Roof();
                    all.Add(roof);
                }
                else
                {
                    house = new House();
                    all.Add(house);
                }
            }
            foreach(var item in all.Reverse<IPart>())
            {
                Console.WriteLine(item.Create());
            }
            Console.ReadLine();
        }
    }
}
