using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFoundation
{
    public class ConvertHelper
    {

    }

    interface IContravariant<in A>
    {
         
    }

    interface IExtContravariant<in A>:IContravariant<A>
    {
         
    }
}
