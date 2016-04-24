using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class ConvertHelper
    {
        public static void Execute()
        {
            IContravariant<object> iobj = new Sample<object>();
            IContravariant<string> isstr = new Sample<string>();

            isstr = iobj;
        }
    }

    interface IContravariant<in A>
    {
         
    }

    interface IExtContravariant<in A>:IContravariant<A>
    {
         
    }

    public class Sample<A> : IContravariant<A>
    {
        
    }
}
