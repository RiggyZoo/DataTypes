using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "--help")
            {
                getHelp();
            }
            else if (args[0] == "--setDate")
            {
                setDate(args);
            }
            else if (args[0] == "--addDays")
            {
                addDaysToCuttentDate(args);
            }
            else if (args.Length >= 0)
            {
                Console.WriteLine("Use --help for help.");
            }
        }

        static void getHelp()
        {
            string[] commands = {"List of commands:\n",
                                 "1.--help => Shows all avalible commands\n.",
                                 "2.--setDate <yyyy-mm-dd> => Set a new DateTime.\n",
                                 "3.--setDate <yyyy-mm-dd> add <number of days> => Set a new DateTime and adds the specified number of days to it.\n",
                                 "4.--addDays <number of days> => Adds the specified number of days to the current Date."};
            foreach (string items in commands)
            {
                Console.WriteLine(items);
            }
        }

        static void setDate(string[] args)
        {
            if (args.Length > 3)
            {
                upgradeNewDate(args);
            }
            else
            {
                string dateStr = args[1].ToString();
                string[] valueDate = dateStr.Split('-');

                DateTime newDt = new DateTime(int.Parse(valueDate[0]), int.Parse(valueDate[1]), int.Parse(valueDate[2]));

                Console.WriteLine($"You set a new DateTime. Current DateTime is {newDt:d}");
                Console.ReadKey();
            }
        }
        static void upgradeNewDate(string[] args)
        {
            string dateStr = args[1].ToString();
            string[] valueDate = dateStr.Split('-');

            DateTime newDt = new DateTime(int.Parse(valueDate[0]), int.Parse(valueDate[1]), int.Parse(valueDate[2]));
            if (args[2] == "add")
            {
                int day = Convert.ToInt32(args[3].ToString());
                DateTime newDate = newDt.AddDays(day);

                Console.WriteLine($"You added a {day} days and your new DateTime is {newDate:d}");

            }
        }
        static void addDaysToCuttentDate(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            string daysStr = args[1].ToString();
            int days = int.Parse(daysStr);

            DateTime newDate = currentDate.AddDays(days);

            Console.WriteLine($"You added {days} days to currunt DateTime. New DateTime is {newDate:D}");
        }
    }

}



