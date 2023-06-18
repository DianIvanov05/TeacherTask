using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teachers11d
{
    public class IComparerClass:IComparer<Teacher>
    {
       public int Compare(Teacher x, Teacher y)
        {
            int result = y.Classes.CompareTo(x.Classes);
            if (result == 0)      
                result = x.Classes.CompareTo(y.Classes);
            return result;
        }
    }
}
