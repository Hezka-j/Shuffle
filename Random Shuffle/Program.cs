using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;

namespace Random_Shuffle
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            string strings = str.ToString();
           
            int number = 1;
            bool ok = false;
            
            for (int i = 0; i < str.Length; i++)
            {
                number *= i + 1;
            }
            for (int i = 0; i < number / str.Length; i++)
            {             
                if(i < str.Length)
                {
                    ok = false;
                    var temp = str[i];
                    str[i] = str[0];
                    str[0] = temp;
                    Console.WriteLine(str);
                    for (int j = 1; j < str.Length - 1; j++)
                    {
                        var temp2 = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = temp2;
                        Console.WriteLine(str);
                        //Console.WriteLine(str[str.Length - 1]);
                        if (str[str.Length - 1] == str[j + 1] && !ok)
                        {                           
                            var temp3 = str[j - 1];                               
                            str[j - 1] = str[j + 1];
                            str[j + 1] = temp3;
                            j = 0;
                            Console.WriteLine(str);
                            ok = true;
                        }
                    }
                    str = new StringBuilder(strings);
                }                                                    
            }
        }
    }
}
