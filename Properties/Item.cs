using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Item
    {
        private DateTime creationDate;

        #region Propertes
        //public возвращаемый_тип Имя { get; set; }
        public long Id { get; private set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime CreationDate
        {
            get
            {
                //тут много разных действий
                return creationDate;
            }
            set
            {
                //тут много разных действий
                creationDate = value;
            }
        }
        #endregion
    }
}
