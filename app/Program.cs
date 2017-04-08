using System;

namespace TI
{
    class MyUnit : Unit.IUnit
    {
        public byte Cost { get; protected set; }

        internal MyUnit(byte cost)
        {
            Cost = cost;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyUnit unit = new MyUnit(10);
            Console.WriteLine(unit.Cost);
        }
    }
}
