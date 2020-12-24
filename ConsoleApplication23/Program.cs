using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class table 
    {
        private string subject;
        private string day;
        private int hour;
        private int min;
        public table()
        { 
        this.day = "";
        this.subject = "";
        this.hour = 0;
        this.min = 0;
        }
        public table (string subject, string day, int hour, int min)
        {
            this.day = day;
            this.subject = subject;
            this.hour = hour;
            this.min = min;
        }

        public void cw()
        {
            Console.WriteLine(subject + "  " + day + "  " + hour + " : " + min );
        }

        public string Subject
        {
            set { subject = value; }
            get { return subject; }
        
        }

        public string Day
        {
            set { day = value; }
            get { return day; }
        }

        public int Hour
        {
            set
            
            {

                if (value < 8 || value > 16)
                {
                }
                else
                {
                    hour = value;
                }
           
            }
            get 
            {
                return hour;
            }
        }

        public int Min
        {
            set
            {
                if (value >= 60 || value < 0)
                {
                }
                else
                {
                    min = value;
                }
            }
            get
            {
                return min;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //int hour=0, min,
            int counter = 0;
            string wantmore;
            //string subject, day 
            table [] x = new table [7];

            for (int i = 0; i < 2; i++)
            {
                x[i] = new table();
                Console.Write("Enter the name of the subject : ");
                //subject
                x[i].Subject= Console.ReadLine();
                Console.Write("Enter the day of the subject : ");
                //day
                x[i].Day= Console.ReadLine();
                Console.Write("Enter the hour of the subject : ");
                x[i].Hour= int.Parse(Console.ReadLine());
                for (int j = 0;; j++)
                {
                    if (x[i].Hour < 8 || x[i].Hour > 16)
                    {
                        Console.WriteLine("we dont do that her. ");
                        x[i].Hour = int.Parse(Console.ReadLine());
                    }
                    else
                        break;
                }
                
                Console.Write("Enter the minute of the subject : ");
                x[i].Min= int.Parse(Console.ReadLine());
          
                    for (int j = 0; j < i; j++)
                    {
                        if (x[i].Hour == x[j].Hour)
                        {
                            Console.Write("Enter the hour agen plees : ");
                            x[i].Hour = int.Parse(Console.ReadLine());
                            j--;
                        }
                    }

                    //for (int j = 0; j < i; j++)
                    //{
                    //    if (x[i].Min == x[j].Min)
                    //    {
                    //        Console.Write("Enter the minute agen plees : ");
                    //        x[i].Min = int.Parse(Console.ReadLine());
                    //        j--;
                    //    }
                    //}

                Console.WriteLine("Do you want to add more subjects ? ");
                wantmore = Console.ReadLine();
                if (wantmore=="no")
                {
                    break;
                }
                counter+=1;
            }
            for (int i = 0; i <= counter; i++)
			{
			 x[i].cw();
			}
        }
    }
}
