using System;

namespace Liskov_Substitution
{
    //Bad Example----------------------------------
    //public class Apple
    //{
    //    public virtual string GetColor()
    //    {
    //        return "Red";
    //    }
    //}
    //public class Orange : Apple
    //{
    //    public override string GetColor()
    //    {
    //        return "Orange";
    //    }
    //}
    //Good Example-------------------------------------------
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
    //Gorduyunuz kimi abstract class icerisinde abstract metod yaradaraq  diger classlarda implement edilmesine mecbur edirik.
    //Bu prinsipə görə yalnız base classın derived classları əvəz etməsidir.Ve bizde bunu tetbiq etdik
    class Program
    {
        static void Main(string[] args)
        {
            //Apple apple = new Orange();
            //Console.WriteLine(apple.GetColor());
            //Good Example  ------
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
