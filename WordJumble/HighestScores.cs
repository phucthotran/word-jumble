using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace WordJumble
{
    class HighestScores : IComparable
    {
        protected string _Name;
        protected int _Point;
        protected int _Bonus;
        protected int _Missed;
        protected int _Time;        
        protected HighestScores[] _lstScores = new HighestScores[10];
        protected int idx;
        protected int markPosition = 0;

        public HighestScores()
        {
            _Name = null;
            _Point = 0;
            _Bonus = 0;
            _Missed = 0;
            _Time = 0;            
            idx = 0;            
        }

        public HighestScores(string sName, int iPoint, int iBonus, int iMissed, int iTime)
        {
            _Name = sName;
            _Point = iPoint;
            _Missed = iMissed;
            _Bonus = iBonus;
            _Time = iTime;            
            idx = 0;            
        }

        public string Name { set { _Name = value; } get { return _Name; } }
        public int Point { set { _Point = value; } get { return _Point; } }
        public int Bonus { set { _Bonus = value; } get { return _Bonus; } }
        public int Missed { set { _Missed = value; } get { return _Missed; } }
        public int Time { set { _Time = value; } get { return _Time; } }

        public int CompareTo(object obj)
        {
            if (obj is HighestScores)
            {
                HighestScores hsc = (HighestScores)obj;
                return Point.CompareTo(hsc.Point);
            }
            return 1;
        }

        public bool IsExist()
        {
            if (File.Exists(@"Scores\" + WordJumble.Properties.Settings.Default.Mode.Trim() + ".wjhs"))
            {
                return true;
            }
            return false;
        }

        public void CreateFile()
        {
            if (!Directory.Exists("Scores"))
            {
                Directory.CreateDirectory("Scores");
            }
            using (FileStream fs = new FileStream(@"Scores\" + WordJumble.Properties.Settings.Default.Mode.Trim() + ".wjhs", FileMode.CreateNew, FileAccess.Write, FileShare.Write))
            {
                StreamWriter sWriter = new StreamWriter(fs);
                sWriter.WriteLine(_lstScores[0].Name + ',' + _lstScores[0].Point + ',' + _lstScores[0].Bonus + ',' + _lstScores[0].Missed + ',' + _lstScores[0].Time);
                sWriter.Flush();
                sWriter.Close();
            }
        }

        /// <summary>
        /// Check point If point is greater than Highest Scores
        /// </summary>
        /// <param name="Point">Point to check</param>
        /// <returns>Return boolean</returns>
        public bool IsHighestScore(int Point)
        {
            //int count = 0;
            //int postPosition = 0;
            int lessPoint = 0;
            string[] arr = new string[5];
            int idx = 0;

            if (IsExist())
            {
                using (StreamReader sReader = new StreamReader(@"Scores\" + WordJumble.Properties.Settings.Default.Mode.Trim() + ".wjhs"))
                {
                    string line = sReader.ReadLine();
                    foreach (string s in line.Split(','))
                    {
                        arr[idx] = s;
                        idx++;
                    }
                    lessPoint = Int32.Parse(arr[1]);
                    /* ANOTHER WAY
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ',')
                        {
                            count++;
                            if (count == 2)
                            {
                                lessPoint = Int32.Parse(line.Substring(postPosition + 1, i - (postPosition + 1)));
                            }
                            postPosition = i;
                        }
                    }*/
                }

                if (Point >= lessPoint)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsTopTen()
        {
            if (IsExist())
            {
                LoadScores();
                int count = 0;

                foreach (HighestScores lst in _lstScores)
                {
                    if (lst == null)
                    {
                        count++;
                        if (count > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsNameExist()
        {            
            for (int i = 0; i < _lstScores.Length; i++)
            {
                if (_lstScores[i] != null && Name == _lstScores[i].Name)
                {                    
                    markPosition = i;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Add scores to array
        /// </summary>
        public void AddScores()
        {
            LoadScores();
            if (!IsNameExist())
            {
                if (idx < _lstScores.Length)
                {
                    _lstScores[idx] = new HighestScores(Name, Point, Bonus, Missed, Time);
                    idx++;
                }                
            }
            else
            {
                if (Point > _lstScores[markPosition].Point)
                {
                    _lstScores[markPosition].Point = Point;
                    _lstScores[markPosition].Bonus = Bonus;
                    _lstScores[markPosition].Missed = Missed;
                    _lstScores[markPosition].Time = Time;
                }
            }
            SortScores();
        }

        private void LoadScores()
        {
            if (File.Exists(@"Scores\" + WordJumble.Properties.Settings.Default.Mode.Trim() + ".wjhs"))
            {
                using (StreamReader sReader = new StreamReader(@"Scores\" + WordJumble.Properties.Settings.Default.Mode.Trim() + ".wjhs"))
                {
                    while (!sReader.EndOfStream)
                    {
                        string[] _tempLst = new string[5];
                        string line = sReader.ReadLine();
                        int indx = 0;

                        foreach (string s in line.Split(','))
                        {
                            if (indx < _tempLst.Length)
                            {
                                _tempLst[indx] = s;
                                indx++;
                            }
                        }
                        if (idx < _lstScores.Length)
                        {
                            _lstScores[idx] = new HighestScores(_tempLst[0], Int32.Parse(_tempLst[1]), Int32.Parse(_tempLst[2]), Int32.Parse(_tempLst[3]), Int32.Parse(_tempLst[4]));
                            idx++;
                        }
                    }
                }                
            }
        }        

        /// <summary>
        /// Sort scores by point
        /// </summary>
        private void SortScores()
        {
            ArrayList _lstSave = new ArrayList();
            for (int i = 0; i < _lstScores.Length; i++)
            {
                if (_lstScores[i] != null)
                {
                    _lstSave.Add(_lstScores[i]);
                }
            }
            _lstSave.Sort();
            _lstSave.Reverse();
            SaveToFile(_lstSave);
        }

        /// <summary>
        /// Save all scores to text files
        /// </summary>
        /// <param name="list">List all scores</param>
        private void SaveToFile(ArrayList list)
        {
            using (StreamWriter sWriter = new StreamWriter(@"Scores\" + WordJumble.Properties.Settings.Default.Mode.Trim() + ".wjhs"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sWriter.WriteLine(((HighestScores)list[i]).Name + ',' + ((HighestScores)list[i]).Point + ',' + ((HighestScores)list[i]).Bonus + ',' + ((HighestScores)list[i]).Missed + ',' + ((HighestScores)list[i]).Time);
                }
            }            
        }
    }
}
