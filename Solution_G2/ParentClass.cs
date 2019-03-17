using System;

namespace Solution_G2
{
    public class ParentClass
    {
      protected internal  int myInt=123232;
        public byte myByte=123;
        public bool myBool = false;
        public char myChar = 'd';
        public string myString = "Abc";

        public float myFloat = 3.14f;
        public double myDouble = 5.56;
        public decimal myDecimal = 345m;
        public long myLong = 34554642L;
        public uint unsignedInt;

        public virtual void TestMethod()
        {
            Console.WriteLine("Parent class");
        }

    }
}
