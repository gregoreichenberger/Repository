using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ValidAgeAttribute : Attribute
    {
        private int _min;
        private int _max;
        private int _age;
        private string _errmsg;

        public ValidAgeAttribute(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public int Age
        { set { _age = value; } }

        public int Min 
        { get { return _min; } }

        public int Max
        { get { return _max; } }

        public bool IsValid(int _age)
        {
            if (_age >= _min && _age <= _max)
                return true;
            return false;
        }

        public string ErrMsg
        {
            get { return _errmsg; }
            set { _errmsg = value; }
        }
        
    }

}
