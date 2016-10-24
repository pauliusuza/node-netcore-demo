using System;
using System.Threading.Tasks;

namespace nodenet {

    public class Person
    {
        public int anInteger = 1;
        public double aNumber = 3.1415;
        public string aString = "hello world";
        public bool aBoolean = true;
        public byte[] aBuffer = new byte[10];
        public object[] anArray = new object[] { 1, "foo" };
        public object anObject = new { a = "foo", b = 12 };
    }

    public class Startup
    {
        public async Task<object> Invoke(dynamic input)
        {
            Person person = new Person();
            return person;
        }

    }

}