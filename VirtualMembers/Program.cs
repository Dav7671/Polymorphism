using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass B = new DerivedClass();
            B.DoWork();  // Calls the new method.

            BaseClass A = B;
            A.DoWork();  // Also calls the new method.

            DerivedClass C = new DerivedClass();
            C.DoWork();  // Calls the new method.

            BaseClass D = (BaseClass)C;
            D.DoWork();  // Calls the old method.
        }

        public class BaseClass
        {
            public virtual void DoWork() { }
            public virtual int WorkProperty
            {
                get { return 0; }
            }
        }
        public class DerivedClass : BaseClass
        {
            public override void DoWork() { }
            public override int WorkProperty
            {
                get { return 0; }
            }
        }
    }

}
