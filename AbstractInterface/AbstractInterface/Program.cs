using System;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract,Sealed
            //Shark shark = new Shark();

            ////string str = "word";
            ////Console.WriteLine(str.Length);

            //Software s = new Software();
            //s.Name = "Cefer";
            #endregion

            #region Nullable value type
            int? a = 10;
            ShowPage(a);
            #endregion

        }

        #region Nullable value type
        static void ShowPage(int? id)
        {
            if (id != null)
            {
                Console.WriteLine("Phone id:"+id);
                return;
            }
            Console.WriteLine("All phones");
        }
        #endregion
    }

    #region Interface
    interface ITest { }
    interface ISum:ITest
    {
        public int MyProperty { get; set; }
        int Sum(int n1,int n2);

        public int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

    }

    interface IDifference
    {
        int Difference(int n1, int n2);
    }

    class Calculator : Test,ISum,IDifference
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Difference(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    #endregion

    #region Abstract - can't get instance
    class Test { }
    abstract class Animal:Test
    {
        public abstract int MyProperty { get; set; }
        protected Animal()
        {
            Console.WriteLine("Animal created");
        }
        public abstract void Eat();

        public virtual void Test()
        {
            Console.WriteLine("Test");
        }
    }

    abstract class Fish:Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish
    {
        public override int MyProperty { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }
    #endregion

    #region Sealed

    abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public virtual void Info()
        {
            Console.WriteLine("Person class");
        }
    }

    abstract class Engineer:Person
    {
        public override void Info()
        {
            Console.WriteLine("Engineer");
        }
    }

    abstract class ReservOIR: Engineer
    {
        public override void Info()
        {
            Console.WriteLine("ReservOIR");
        }
    }

    abstract class Developer: Engineer
    {
        public sealed override void Info()
        {
            Console.WriteLine("Developer");
        }
    }

    sealed class Software : Developer
    {
        public override string Name { get; set; }
        public override string Surname { get; set; }
    }

    //class Test1:Software
    //{

    //}
    #endregion

    #region Static readonly members
    //class Test
    //{
    //    //public static int MyProperty { get; }
    //    public static readonly int MyProperty;
    //    static Test()
    //    {
    //        MyProperty = 10;
    //    }
    //    public Test()
    //    {
    //        Console.WriteLine(MyProperty);
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine(MyProperty);
    //    }

    //}
    #endregion
}
