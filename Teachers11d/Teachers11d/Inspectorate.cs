using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers11d
{
    public abstract class Inspectorate:IPrint
    {
        protected string inspectorateName;

        public Inspectorate(string inspectorateName)
        {
            this.inspectorateName = inspectorateName;
        }

        public virtual void Print()
        {
            Console.WriteLine($" {this.inspectorateName}");
        }

        public abstract void  Count();

    }
}
