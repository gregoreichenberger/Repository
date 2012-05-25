using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttributeSample.Attributes
{
    // Create custom attribute to be assigned to class members
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Field |
     AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
    public class BugFixAttribute : System.Attribute
    {
        private int _bugId;
        private string _programmer;
        private string _date;
        private string _comment;

        // attribute constructor for positional parameters
        public BugFixAttribute(int bugId, string programmer, string date)
        {
            _bugId = bugId;
            _programmer = programmer;
            _date = date;
        }

        public int BugId
        { get { return _bugId; } }

        public string Programmer
        { get { return _programmer; } }

        public string Date
        { get { return _date; } }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
    }
}