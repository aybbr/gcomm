using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class EloBoostingService
    {
        public EloBoostingService()
        {


        }
        public static string DivisionFinder(Double a)
        {
            string Div;
            if (a == 0)
            {
                Div = "Bronze 5";
                return Div;
            }
            else if (a == 5)
            {
                Div = "Bronze 4";
                return Div;
            }
            else if (a == 10)
            {
                Div = "Bronze 3";
                return Div;
            }
            else if (a == 15)
            {
                Div = "Bronze 2";
                return Div;
            }
            else if (a == 20)
            {
                Div = "Bronze 1";
                return Div;
            }
            else if (a == 25)
            {
                Div = "Silver 5";
                return Div;
            }
            else if (a == 30)
            {
                Div = "Silver 4";
                return Div;
            }
            else if (a == 35)
            {
                Div = "Silver 3";
                return Div;
            }
            else if (a == 40)
            {
                Div = "Silver 2";
                return Div;
            }
            else if (a == 45)
            {
                Div = "silver 1";
                return Div;
            }
            else if (a == 50)
            {
                Div = "Gold 5";
                return Div;
            }
            else if (a == 55)
            {
                Div = "Gold 4";
                return Div;
            }
            else if (a == 60)
            {
                Div = "Gold 3";
                return Div;
            }
            else if (a == 65)
            {
                Div = "Gold 2";
                return Div;
            }
            else if (a == 70)
            {
                Div = "Gold 1";
                return Div;
            }

            else return "No Division";

        }
        public static Double XPFinder(string a)
        {
            String z ="Silver 3";
            if (a.Equals("Bronze 5"))
            {
                return 0d;
            }
            else if (a.Equals("Bronze 4"))
            {
                return 5d;
            }
            else if (a.Equals("Bronze 3"))
            {
                return 10d;
            }
            else if (a.Equals("Bronze 2"))
            {
                return 15d;
            }
            else if (a.Equals("Bronze 1"))
            {
                return 20d;
            }
            else if (a.Equals("Silver 5"))
            {
                return 25d;
            }
            else if (a.Equals("Silver 4"))
            {
                Console.WriteLine("ouir silver 4 ");
                return 30d;
            }
            
            else if (a.Equals(z))
            {
                Console.WriteLine("ouir silver 3 ");
                return 35d;
            }
            else if (a.Equals("Silver 2"))
            {
                return 40d;
            }
            else if (a.Equals("Silver 1"))
            {
                return 45d;
            }
            else if (a.Equals("Gold 5"))
            {
                return 50d;
            }
            else if (a.Equals("Gold 4"))
            {
                return 55d;
            }
            else if (a.Equals("Gold 3"))
            {
                return 60d;
            }
            else if (a.Equals("Gold 2"))
            {
                return 65d;
            }
            else if (a.Equals("Gold 1"))
            {
                return 70d;
            }
            else return 11d;
        }

        public static int numberOfDays(Double a, Double b)
        {
            Console.WriteLine("yes");

            int cmp = 0;

            // Bronze to Bronze
            if (a < 25 && b <= 25)
            {
                for (int i = Convert.ToInt32(a); i < Convert.ToInt32(b); i = i + 5)
                {
                    Console.WriteLine(cmp);
                    cmp = cmp + 3;
                    Console.WriteLine(cmp);
                }
                Console.WriteLine("hedhi" + cmp);
                return cmp;

            }
            //Bronzzzze to silverrrrr
            else if (a < 25 && b >= 25 && b < 50)
            {
                Console.WriteLine("awel");
                for (int i = Convert.ToInt32(a); i < 25; i = i + 5)
                {
                    cmp = cmp + 3;
                }
                for (int i = 25; i < Convert.ToInt32(b); i = i + 5)
                {
                    cmp = cmp + 4;
                }
                Console.WriteLine("ouiii");
                return cmp;

            }
            //bronze to gold
            else if (Convert.ToInt32(a) < 25 && Convert.ToInt32(b) >= 50)
            {

                for (int i = Convert.ToInt32(a); i < 25; i = i + 5)
                {


                    cmp = cmp + 3;


                }
                for (int i = 25; i < 50; i = i + 5)
                {

                    cmp = cmp + 4;

                }
                for (int i = 50; i < Convert.ToInt32(b); i = i + 5)
                {
                    cmp = cmp + 5;

                }
                return cmp;

            }
            //		silver to silver
            else if (a >= 25 && b <= 50)
            {

                for (int i = Convert.ToInt32(a); i < Convert.ToInt32(b); i = i + 5)
                {

                    cmp = cmp + 4;

                }
                return cmp;

            }
            //silver to gold
            else if (a >= 25 && b >= 50 && a < 50)
            {
                for (int i = Convert.ToInt32(a); i < 50; i = i + 5)
                {
                    cmp = cmp + 4;
                }
                for (int i = 50; i < Convert.ToInt32(b); i = i + 5)
                {
                    cmp = cmp + 5;
                }
                return cmp;
            }
            //gold to gold
            else if (a >= 50 && b <= 70)
            {

                for (int i = Convert.ToInt32(a); i < Convert.ToInt32(b); i = i + 5)
                {
                    Console.WriteLine("trah");
                    cmp = cmp + 5;
                }
                return cmp;
            }


            else return 0;
        }

        public static int Facture(int a)
        {
            int facture = a * 5;
            return facture;
        }
    }
}
