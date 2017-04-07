using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamGehem
{
    class CsvParser
    {
        public IList<IDictionary<string, string>> ParserCsv(string csv_path)
        {
            using (StreamReader sr = new StreamReader(csv_path, Encoding.UTF8))
            {
                List<IDictionary<string, string>> list = null;

                if (!sr.EndOfStream)
                {
                    list = new List<IDictionary<string, string>>();
                    Dictionary<string, string>[] dic_array = null;

                    string s = sr.ReadLine();
                    string[] temp = s.Split(',');
                    if (temp.Length > 1)
                    {
                        dic_array = new Dictionary<string, string>[temp.Length - 1];
                        for (int i = 0; i < dic_array.Length; ++i)
                        {
                            dic_array[i] = new Dictionary<string, string>();
                            dic_array[i][temp[0]] = temp[i+1];
                        }
                    }
                    while (!sr.EndOfStream)
                    {
                        s = sr.ReadLine();
                        temp = s.Split(',');

                        if(temp.Length <= dic_array.Length)
                        {
                            string[] temp2 = new string[dic_array.Length + 1];
                            Array.Copy(temp, temp2, temp.Length);

                            for(int i= temp.Length; i <= dic_array.Length; ++i)
                            {
                                temp2[i] = string.Empty;
                            }
                            temp = temp2;
                        }

                        for (int i = 0; i < dic_array.Length; ++i)
                        {
                            dic_array[i][temp[0]] = temp[i + 1];
                        }
                    }

                    for (int i = 0; i < dic_array.Length; ++i)
                    {
                        list.Add(dic_array[i]);
                    }
                }
                return list;
            }
        }
    }
}
