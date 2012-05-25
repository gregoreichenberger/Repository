using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributeSample.Attributes;

namespace AttributeSample
{
    [BugFix(1, "Gregor Eichenberger", "15.05.2012" , Comment="Well done...")]
    public class MyMath
    {

        public double DoFunc(double param1)
        {
            return param1 + Logic(param1);
        }

        private double Logic(double param1)
        {
            return param1 / 3;
        }

    }
}
