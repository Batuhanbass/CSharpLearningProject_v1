using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningProject_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.aLogger = new SmsLooger();
            //customerManager.aLogger=new DatabaseLogger();
            customerManager.aLogger = new FileLogger();

        }
    }
    class CustomerManager
    {
        public Ilogger aLogger { get; set; }
        public void add()
        {
            aLogger.Log();
            Console.WriteLine("Customeradder!");

        }
    }
    class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database");


        }
    }
    class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");


        }
    }
    class SmsLooger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to sms");


        }
    }

    interface Ilogger
    {
        void Log();
    }

    
}
