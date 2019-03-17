using System;

namespace Solution_G2
{
    class Program
    {

                       static void Main(string[] args)
        {
            //Isplicit types convertion
            // int a = 50;
            // byte b = 7;
            // b = (byte)a;
            // Console.WriteLine(b);
            ParentClass parentClass = new ParentClass();
            parentClass.myBool = true;
            // Console.WriteLine(parentClass.myBool);

            ChildClass childClass = new ChildClass();
           // Console.WriteLine(childClass.myByte);
          //  Console.WriteLine(childClass.childInt);

            ParentClass parentClass1 = new ChildClass();

            // impossible, follow us to exception
            // childClass= (ChildClass)parentClass;
            // Console.WriteLine(childClass.childInt);

            childClass.TestMethod();

            Console.ReadKey();
            

        }
    }
}
