using System.Data;
using System;
namespace CS2023
{
    class Helper
    {
        public static string OutArray<T>(T[] array)
        {
            string result = string.Empty;
            foreach (T item in array)
                result += item is null ? "" : item.ToString() + ",";
            return result.Trim(',');
        }
    }

}