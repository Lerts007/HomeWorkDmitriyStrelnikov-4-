using System;
using System.IO;

namespace Task_2
{
    public class FileWorker
    {
        string path;
        MatrixWorker mw;

        public FileWorker(string path)
        {
            this.path = path;
            ReadByFile();
        }

        public void ReadByFile()
        {
            StreamReader sr = new StreamReader(path);
            string t = String.Empty;

            var arg = sr.ReadLine().Split(' ');

            mw = new MatrixWorker(row: int.Parse(arg[0]), int.Parse(arg[1]));

            int x = 0;
            int y = 0;

            while (!sr.EndOfStream)
            {
                t = sr.ReadLine();
                while (t != "")
                {
                    t += " ";

                    int pos = t.IndexOf(' ');
                    int num = Convert.ToInt32(t.Substring(0, pos));

                    mw.SetElemetByIndex(num, x, y);
                    y++;

                    t = t.Substring(pos).Trim();
                }
                x++;
                y = 0;

            }
            sr.Close();
        }

        public void Print()
        {
            mw.Print();
        }
    }
}