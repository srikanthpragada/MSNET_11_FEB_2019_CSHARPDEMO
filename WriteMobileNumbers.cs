using System.IO;
using System;

namespace csharpdemo
{
    class WriteMobileNumbers
    {

        static bool IsMobileNumber(string s)
        {
            if (s.Trim().Length != 10)
                return false;

            for (int i = 0; i < s.Length; i++)
                if (!Char.IsDigit(s[i]))
                    return false;

            return true;
        }


        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader
                (@"e:\classroom\msnet\feb11\phones.txt");

            StreamWriter sw = new StreamWriter
                (@"e:\classroom\msnet\feb11\mobile.txt");

            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;

                // ignore line if it is blank
                if (line.Trim().Length == 0)
                    continue;

                // split line using , 
                string[] parts = line.Split(',');

                // write to target file
                foreach (string p in parts)
                {
                    if (IsMobileNumber(p))
                        sw.WriteLine(p);
                }
            } // while

            sr.Close();
            sw.Close();
        }
    }
}
