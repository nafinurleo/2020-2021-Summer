using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_My_Work_Week9
{
    class GenericClass<T>
    {
        private T value;
        public T Value
        {
            set;
            get;
        }
    }
}
