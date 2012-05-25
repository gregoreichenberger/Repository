using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AttributeSample.Attributes;
using AttributeSample.Model;

namespace AttributeSample
{
    // http://www.c-sharpcorner.com/UploadFile/mgold/CreatingnUsingCustomAttributesinCS12032005055442AM/CreatingnUsingCustomAttributesinCS.aspx
    // http://msdn.microsoft.com/en-us/library/tw5zxet9(v=vs.80).aspx
    // http://oreilly.com/catalog/progcsharp/chapter/ch18.html
    
    class Program
    {
        public Program()
        { }

        static void Main(string[] args)
        {
            Program p = new Program();
            //p.LoadAssembly("Mscorlib.dll");
            p.GetSingleType("AttributeSample.Attributes.ValidAgeAttribute");


        }

        public void GetSingleType(string assemblyType)
        {
            Type type = Type.GetType(assemblyType);
            Console.WriteLine("The type is: {0}", type);

            MemberInfo[] memberInfos = type.GetMembers();
            //MemberInfo[] memberInfos = type.GetMethods();
            foreach (MemberInfo memberInfo in memberInfos)
            {
                Console.WriteLine("{0} is: {1}", memberInfo, memberInfo.MemberType);
            }

            Console.ReadKey();
        }

        public void LoadAssembly(string assembly)
        {
            Assembly a = Assembly.Load(assembly);

            Type[] types = a.GetTypes();

            foreach (Type t in types)
            {
                Console.WriteLine("Type is: {0}", t);
            }
            Console.ReadKey();
        }

        public void GetMathInfo()
        {
            System.Reflection.MemberInfo info = typeof(MyMath);
            object[] attributes;
            attributes = info.GetCustomAttributes(typeof(BugFixAttribute), false);

            foreach (object attribute in attributes)
            {
                BugFixAttribute bfa = (BugFixAttribute)attribute;
                Console.WriteLine("BugId: {0}", bfa.BugId);
                Console.WriteLine("Programmer: {0}", bfa.Programmer);
                Console.WriteLine("Date: {0}", bfa.Date);
                Console.WriteLine("Comment: {0}", bfa.Comment);
            }

            Console.ReadKey();
        }

        public Member CreateMember()
        {
            Member m = new Member();

            m.Id = 1;
            m.FirstName = "Gregor";
            m.LastName = "Eichenberger";
            m.Age = 2;

            return m;
        }
    }


}
