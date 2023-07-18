using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmSort
{
    public static class Extension
    {

        // array massiv sort
        public static void Sorting(this int[] arr)
        {
            int uzgaruvchi;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        uzgaruvchi = arr[i];
                        arr[i] = arr[j];
                        arr[j] = uzgaruvchi;

                    }
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        //********************************************************************//

        // string massiv sort

        public static void Sorting(this string z)
        {
            char uzgaruvchi;
            string mystring = z;
            string str = mystring.ToLower();
            char[] chars = str.ToCharArray();
            for (int i = 1; i < chars.Length; i++)
            {
                for (int j = 0; j < chars.Length - 1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        uzgaruvchi = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = uzgaruvchi;
                    }
                }

            }
            Console.WriteLine(chars);
        }

        // list <int> sort

        public static void Sorting(this List<int> list)
        {
            int temp = new int();


            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }

            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

        }
        /********************************************************************/


        // string massiv sort

        public static void Sorting(this string[] str)
        {
            
            string temp;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length-1; j++)
                {
                    if (str[j].CompareTo(str[j + 1]) > 0)
                    {
                        temp = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i] + " ");
            }
        }

        /**********************************************************************/
        // List<string> Sort

        public static void Sorting(this List<string> str)
        {
         
            string temp;


            for (int i = 0; i < str.Count; i++)
            {
                for (int j = 0; j < str.Count-1; j++)
                {
                    if (str[j].CompareTo(str[j + 1]) > 0)
                    {
                        temp = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < str.Count; i++)
            {
                Console.WriteLine(str[i] + " ");
            }
        }

    }
}
