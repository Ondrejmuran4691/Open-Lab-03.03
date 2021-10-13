using System;

namespace Open_Lab_03._03
{
    public class Comparator
    {
        public bool CompareCharactersCount(string str1, string str2)
        {
            int l1 = str1.Length;
            int l2 = str2.Length;
            if (l1 == l2)

            {
                return true;
            }
            else
            {
                return false;
                }
            }
    }
}
