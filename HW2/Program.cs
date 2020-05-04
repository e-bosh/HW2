using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    abstract class Worker
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double PayType { get; set; }
        public abstract void CalculatePay();
    }
    class HourlyPayWorker : Worker
    {
        public HourlyPayWorker(int id, string name, float paytype)
        {
            ID = id;
            Name = name;
            PayType = paytype;
        }
        public override void CalculatePay()
        {
            Console.WriteLine("ID= " + ID + " Имя рабочего с почасовой оплатой: " + Name + "\n" + "Его ежемесячная зарплата= " + 20.8 * 8 * PayType + "\n");
            PayType = 20.8 * 8 * PayType;
        }

    }
    class StaticPayWorker : Worker
    {
        public StaticPayWorker(int id, string name, float paytype)
        {
            ID = id;
            Name = name;
            PayType = paytype;

        }
        public override void CalculatePay()
        {
            Console.WriteLine("ID= " + ID + " Имя рабочего с фиксированной оплатой: " + Name + "\n" + "Его ежемесячная зарплата= " + PayType);
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            List<Worker> workers = new List<Worker>();
            workers.Add(new HourlyPayWorker(43, "Андрей", 80));
            workers.Add(new StaticPayWorker(28, "Николай", 15000));
            workers.Add(new HourlyPayWorker(01, "Василий", 150));
            workers.Add(new StaticPayWorker(152, "Максим", 28000));
            workers.Add(new HourlyPayWorker(96, "Игорь", 110));
            workers.Add(new HourlyPayWorker(3, "Алексей", 200));
            workers.Add(new StaticPayWorker(8769, "Елена", 19000));
            workers.Add(new StaticPayWorker(61, "Ирина", 22000));
            workers.Add(new StaticPayWorker(82, "Name1", 90000));
            workers.Add(new HourlyPayWorker(88, "Name2", 88));
            foreach (Worker worker in workers)
                worker.CalculatePay();
            Console.WriteLine("--------------------------------------------" + "\n" + "--------------------------------------------");
            Console.WriteLine("Сортировка по возрастанию");
            Console.ReadKey();


        }
    }
}
