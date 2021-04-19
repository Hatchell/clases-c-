using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    class RandomizerArray
    {
        static Random _randomgen = new Random();

        public static int[] RandomizeStrings(int[] arr)
        {
            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
            // Agregar valores al array

            foreach (int s in arr)
            {
                list.Add(new KeyValuePair<int, int>(_randomgen.Next(), s));
            }
            // Randomizar lista por numero aleatorio
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // introducir valores al nuevo array
            int[] result = new int[arr.Length];
            // copiar valores al array
            int index = 0;
            foreach (KeyValuePair<int, int> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }

            return result;
        }
    }
}
