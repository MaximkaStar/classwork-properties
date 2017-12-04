using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Building
    {
        private long id;
        private int stagesCount;
        private double width;
        private double height;
        private double thickness;
        private string owner;
        private string address;
        //..... и еще 10-20, полей
        private string[] people;
        public string this[int index]
        {
            get
            {
                return people[index];
            }
            set
            {
                people[index] = value;
            }
        }

        public Building()
        {
            
        }

        public long GetId()
        {
            return id;
        }

        public void SetId(long id)
        {
            this.id = id;
        }

        public int GetStagesCount()
        {
            return stagesCount;
        }

        public void SetStagesCount(int stagesCount)
        {
            this.stagesCount = stagesCount;
        }

        //+ дополнительно 100-150 строк
    }
}
