using System;

namespace Interface_Segregation
{
    //Bad Example---------------------------------------
    //interface IRepository
    //{
    //    void WriteData(object data);
    //    object ReadData();
    //}

    //public class DatabaseRepository : IRepository
    //{
    //    public object ReadData()
    //    {
    //        return new object();
    //    }

    //    public void WriteData(object data)
    //    {
    //        //Go to the database and write data
    //    }
    //}

    //public class XmlFileRepository : IRepository
    //{
    //    public object ReadData()
    //    {
    //        //Go to the database and read data
    //        return new object();
    //    }

    //    public void WriteData(object data)
    //    {
    //        //Don't allow a user to write data to the XML Repository.
    //        throw new NotImplementedException();
    //    }
    //}
    //Good Example--------------------------------------------
    interface IReadOnlyRepository
    {
        object ReadData();
    }

    interface IRepository : IReadOnlyRepository
    {
        void WriteData(object data);
    }

    public class DatabaseRepository : IRepository
    {
        public object ReadData()
        {
            //Go to the database and read data
            return new object();
        }

        public void WriteData(object data)
        {
            //Go to the database and write data
        }
    }

    public class XmlFileRepository : IReadOnlyRepository
    {
        public object ReadData()
        {
            //Go to the database and read data
            return new object();
        }
    }
    //Bu prinsipin məqsədi,həqiqətən ehtiyac duyulmayan və sinifdə istifadə olunan metodlar interfeys vasitəsilə tətbiq olunarsa bu Interface Segregation prinsipin pozulmasına yol açır.
    //ve koddan gorunduyu kimi xml file repositorysi sadece datalari oxumaq xusisiyyetine malikdir,
    //Databaserepositorysi ise hem datalari oxumaq hemde yazmaq.Ve biz bu problemi adindanda gorunduy kimi bize lazim olan interfacelere bolerek aradan qaldirdiq.Diger halda xml file repositorysi
    //datalari yazmaq xusisiyyetine malik olmadigindan exception ve yaxud hemin xusisyyeti bos saxlamaq mecburiyyetinde qalacaqdiq
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
