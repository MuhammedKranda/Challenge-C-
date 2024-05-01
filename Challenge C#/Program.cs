using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Challenge_C_
{
    public class Program
    {
        static string SesliHarfSil(string word) // CHALLENGE 2-A
        {
            string letter = "aeıioöuüAEIİOÖUÜ"; 
            return Regex.Replace(word, "[" + letter + "]", ""); //kelimede kaldırmak istediğim sesli harfleri harfta tutuyorum.
        }
   
        static void MoveZerosToEnd(object[] arr)  //CHALLENGE 2-B
        {
            List<object> nonZeros = new List<object>();
            List<object> zeros = new List<object>();

            foreach (var item in arr)
            {
                if (item.Equals(0))
                {
                    zeros.Add(item);
                }
                else
                {
                    nonZeros.Add(item);
                }
            }

            nonZeros.AddRange(zeros);
            nonZeros.CopyTo(arr);

        }


        static void Main(string[] args)  //CHALLENGE 2-A
        {
            Console.WriteLine("Cümle giriniz:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Cümledeki sesli harflerin çıkarılmış hali:"+SesliHarfSil(sentence)); // Kelimedeki sessiz harfleri çıktı veriyor.
            
            
            object[] arr = { false, 1, 0, 1, 2, 0, 1, 3, "a" };  //CHALLENGE 2-B
            MoveZerosToEnd(arr);

            Console.WriteLine(string.Join(", ", arr));
            Console.ReadLine();

        }    

    }
    
}
