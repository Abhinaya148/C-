using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        /* static void Main(string[] args)
         {
             //Program p=new Program();
             //p.Evennum();
             Program.Evennum(50);
         }
         //public void Evennum()
         public static void Evennum(int t)
         {
             int start = 0;
             while(start<=t)
             {
                 Console.WriteLine(start);
                 start=start+2;            }
         } */
        //pass by value 
        /*public static void Main()
        {
            int j= 0;
            Simple(j);
            Console.WriteLine(j);
        }
        public static void Simple(int i)
        {
            i = 203;
        } 
        */
        //pass by reference
        /*public static void Main()
        {
            int j = 0;
            Simple(ref j);
            Console.WriteLine(j);
        }
        public static void Simple(ref int i)
        {
            i = 203;
        }
        */
        // pass by out parameter
        /* public static void Main()
         {
             int Total = 0, Product=0;
             Calculate(15,25,out Total,out Product);
             Console.WriteLine($"Sum = {Total} and Product = {Product}");
         }
         public static void Calculate(int n1, int n2,out int Sum, out int Product)
         {
             Sum = n1 + n2;
             Product = n1 * n2;
         }
        */
        //params parameter
        public static void Main()
        {
            int[] num = new int[4];
            num[0] = 12;
            num[1] = 13;
            num[2] = 14;
            num[3] = 15;
            //Params();
            Params(num);
            Params(1,2,3,4,5);
        }
        public static void Params(params int[] num)
        {
            Console.WriteLine($"There are {num.Length} elements");
            foreach( int i in num )
            {
                Console.WriteLine(i);
            }
        }

    }
}
