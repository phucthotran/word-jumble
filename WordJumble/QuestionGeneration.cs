using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace WordJumble
{
    class QuestionGeneration
    {
        protected int count = 0;
        protected int temp = 0;
        Random randomNum;
        static string s = null;
        protected ArrayList arrQuestion;
        protected ArrayList allQuestion;

        public QuestionGeneration()
        {
            randomNum = new Random();
            arrQuestion = new ArrayList();
            allQuestion = new ArrayList();
        }

        public ArrayList ArrQuestion
        {
            get { return arrQuestion; }
        }

        public string Answer
        {
            get { return s; }
        }

        public void GetQuestion()
        {
            using (FileStream fs = new FileStream("WordJumble.wjdb", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                StreamReader sReader = new StreamReader(fs);
                sReader.BaseStream.Seek(0, SeekOrigin.Begin);                
                
                while (!sReader.EndOfStream)
                {
                    string line = sReader.ReadLine();

                    if (line != null && !line.Contains("Database: "))
                    {
                        allQuestion.Add(line);
                    }
                }
            }
            AddQuestion();
            Swap(arrQuestion);
        }

        private void AddQuestion()
        {
            ArrayList markPosition = new ArrayList();
            int startSplit = 0;
            int j = 0, k = 0;            
            int idx = 0, count = 0;

            s = (string)allQuestion[randomNum.Next(0, allQuestion.Count)];

            //Count space
            foreach (string space in s.Split(' '))
            {
                count++;
            }

            byte[] encode = new byte[count];

            ASCIIEncoding decoder = new ASCIIEncoding();
            foreach (string ascii in s.Split(' '))
            {
                encode[idx] = byte.Parse(ascii);
                idx++;
            }
            s = decoder.GetString(encode);

            if (WordJumble.Properties.Settings.Default.Mode == "Beginner" || WordJumble.Properties.Settings.Default.Mode == "Average")
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        startSplit++;
                    }
                    if (startSplit == 2)
                    {
                        arrQuestion.Add(s.Substring(j, i - j).TrimStart());
                        startSplit = 0;
                        j = i;
                        k = i;
                    }
                    else if (i == s.Length - 1)
                    {
                        arrQuestion.Add(s.Substring(k).TrimStart());
                    }
                }
            }
            else if (WordJumble.Properties.Settings.Default.Mode == "Expert" || WordJumble.Properties.Settings.Default.Mode == "Time Limited")
            {
                foreach (string s2 in s.Split(' '))
                {
                    arrQuestion.Add(s2);
                }
            }
        }

        private void Swap(ArrayList list)
        {
            string tempSwap;
            int tempRandom = 0, time = 0;

            for (int i = randomNum.Next(0, list.Count); ; )
            {
                time++;
                if (time <= 10)
                {
                    tempSwap = list[i].ToString();
                    tempRandom = randomNum.Next(0, list.Count);
                    list[i] = list[tempRandom];
                    list[tempRandom] = tempSwap;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
