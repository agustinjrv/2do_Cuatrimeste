using System;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime ahora = DateTime.Now;
            //DateTime nacio = new DateTime(1994, 12, 17);
            //TimeSpan a = ahora - nacio;
            //Console.WriteLine("RESULTADO: " + a.ToString());

            Console.Title = "Ejercicio_07";
            Console.ForegroundColor = ConsoleColor.Cyan;

            DateTime tiempo ;
            int year;
            int month;
            int day;
            int i;
            int anios;
            int meses=0;
            int dias=0;
            int contador=0;

            Console.Write("Enter the year of birth : ");
            year=int.Parse(Console.ReadLine());

            Console.Write("Enter the month of birth : ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter the day of birth : ");
            day = int.Parse(Console.ReadLine());

            tiempo =DateTime.Now;

            anios = tiempo.Year - year;

            if(month<=2 && day<=29)
            {
                for (i = year; i <= tiempo.Year; i++)
                {
                    if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                    {
                        contador++;
                    }
                }
            }
            else
            {
                

                for (i = year + 1; i <= tiempo.Year; i++)
                {
                    if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                    {
                        contador++;
                    }
                }
            }
            

            for (i = month; i + 1 <= tiempo.Month; i++)
            {
                switch (i)
                {
                    case 1:
                        meses += 31;

                        break;
                    case 2:
                        meses += 28;

                        break;
                    case 3:
                        meses += 31;

                        break;
                    case 4:
                        meses += 30;

                        break;
                    case 5:
                        meses += 31;

                        break;
                    case 6:
                        meses += 30;

                        break;
                    case 7:
                        meses += 31;

                        break;
                    case 8:
                        meses += 31;

                        break;
                    case 9:
                        meses += 30;

                        break;

                    case 10:
                        meses += 31;

                        break;
                    case 11:
                        meses += 30;

                        break;
                    case 12:
                        meses += 31;

                        break;


                }

                if (i == 12)
                {
                    i = 1;
                }
                    
            
            }



            dias += tiempo.Day - day;

            dias += anios * 365;
            dias += meses;
            dias += contador;




            Console.WriteLine("you have {0} days in the world", dias);







            Console.Read();


        }
    }
}
