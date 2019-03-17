using System;

namespace Solution_G2
{
    public class ChildClass : ParentClass 
    {
        public int childInt = 68;
        public override void TestMethod()
        {
            Console.WriteLine("Child class");
        }
    }
}
