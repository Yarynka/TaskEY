using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task_3_3_Person
    {
        int N,n, lengthPage = 10;
        public List<string> RandomStr = new List<string> { };
        public Task_3_3_Person(int N, int n)
        {
            this.N = N;
            this.n = n;
            string result = "";
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                result = "";
                for (int j = 0; j < n; j++)
                {
                    int k = r.Next(65, 91);
                    result += Convert.ToString((char)k);
                }
                RandomStr.Add(result);
            }
        }
        public int Clean()
        {
            bool sort = true;
            while (sort)
            {
                sort = false;
                for (int i = 1; i < N; i++)
                    if (RandomStr[i - 1].CompareTo(RandomStr[i]) < 0)
                    {
                        string temp = RandomStr[i - 1];
                        RandomStr[i - 1] = RandomStr[i];
                        RandomStr[i] = temp;
                        sort = true;
                    }
            }
            string prev ="";
            for (int i = 0; i < RandomStr.Count; i++)
            {
                string st = RandomStr[i];
                if (st[0] == 'Z')
                {
                    RandomStr.Remove(st);
                    i--;
                }
                if (prev == st)
                {
                    RandomStr.Remove(st);
                    i--;
                }

                prev = st;
            }

            return RandomStr.Count;
        }
        public string DisplayPage(int pageNumber)
        {
            string st = "";
            int startPage = pageNumber * lengthPage;
            if (RandomStr.Count < startPage) return "Такої сторiнки не iснує!";
            int endPage = startPage + 10;
            if (RandomStr.Count < endPage) endPage = RandomStr.Count;
            for (int i = startPage; i < endPage; i++)
            {
                st += RandomStr[i] + "\n";
            }
            return st;
        }

    }
    }

