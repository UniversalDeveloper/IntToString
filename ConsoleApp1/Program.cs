using System;

namespace ConsoleApp1
{
    class Program
    {

        public static string ToSting(int number)
        {
            int cut_off_num;
            int counter = 0;
            int pars_num = number;
            int end_work = number;
            int chang_orient= 0;
            bool minus = false;

            int?[] pars_int = new int?[100];
            while (end_work != 0)
            {
                if (pars_num < 0)
                {
                    minus = true;
                    chang_orient = Math.Abs(pars_num);
                 //   Console.WriteLine(a);
                    pars_num = chang_orient;
                    cut_off_num = pars_num % 10;
                    pars_int[counter++] = cut_off_num;
                    pars_num = pars_num / 10;
                    end_work = pars_num;
                }
                else
                {
                    cut_off_num = pars_num % 10;
                    pars_int[counter++] = cut_off_num;
                    pars_num = pars_num / 10;
                    end_work = pars_num;
                }
                //  Console.WriteLine(end_work);
            }
            
            string result = string.Empty;
            string mine_result = string.Empty;
            const string table = "0123456789";
            const string  val= "-";
            
            if (minus == true) {
                for (int i = pars_int.Length - 1; i >= 0; i--)
                {
                    if (pars_int[i] == null) continue;

                    result += table[pars_int[i].Value];
                    mine_result = val + result;
                }
               
                Console.Write(mine_result);
            }
            else {
                for (int i = pars_int.Length - 1; i >= 0; i--)
                {
                    if (pars_int[i] == null) continue;

                    result += table[pars_int[i].Value];

                }
                 Console.Write(result);
                return result;
            }
           
            return mine_result;
        }


        static void Main(string[] args)
        {

            Program.ToSting(-45);
         
        }
    }
}
