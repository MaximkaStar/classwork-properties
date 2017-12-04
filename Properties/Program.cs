using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.Id = 2; //автоматически вызывается set
            long id = item.Id; //автоматически вызывается get

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //object initializer
            Item itemSecond = new Item()
            {
                Id = 1,
                Name = "Товар 1",
                Price = 1000
            };

            ArrayList list = new ArrayList();
            list.Add(1);
            int number = (int)list[0];

            Building building = new Building();
            building[0] = "Вася";
        }
    }
}
