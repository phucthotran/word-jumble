using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordJumble
{
    class LoadGame
    {
        /// <summary>
        /// Load game from file
        /// </summary>
        /// <param name="FileName">File to load</param>
        public static void Process(string FileName)
        {            
            using (StreamReader sReader = new StreamReader(FileName))
            {
                while (!sReader.EndOfStream)
                {
                    string line = sReader.ReadLine();
                    if (line.Contains("Mode:"))
                    {
                        WordJumble.Properties.Settings.Default.Mode4Resume = line.Remove(0, 6);
                    }
                    else if (line.Contains("Point:"))
                    {
                        ResumeSettings.Point = Int32.Parse(line.Remove(0, 7));
                    }
                    else if (line.StartsWith("Bonus:"))
                    {
                        ResumeSettings.Bonus = Int32.Parse(line.Remove(0, 7));
                    }
                    else if (line.Contains("Missed:"))
                    {
                        ResumeSettings.Missed = Int32.Parse(line.Remove(0, 8));
                    }
                    else if (line.Contains("Total Win:"))
                    {
                        ResumeSettings.TotalWin = Int32.Parse(line.Remove(0, 11));
                    }
                    else if (line.Contains("Win Times:"))
                    {
                        ResumeSettings.WinTimes = Int32.Parse(line.Remove(0, 11));
                    }
                    else if (line.Contains("Prepare Bonus:"))
                    {
                        ResumeSettings.PrepareBonus = Int32.Parse(line.Remove(0, 15));
                    }
                    else if (line.Contains("Hint Limit:"))
                    {
                        ResumeSettings.HintLimit = Int32.Parse(line.Remove(0, 12));
                    }
                    else if (line.Contains("Change Question Limit:"))
                    {
                        ResumeSettings.ChangeQuestionLimit = Int32.Parse(line.Remove(0, 23));
                    }
                    else if (line.Contains("Reduce Limit:"))
                    {
                        ResumeSettings.ReduceLimit = Int32.Parse(line.Remove(0, 14));
                    }
                }
                ResumeSettings.SaveSettings();
            }
            WordJumble.Properties.Settings.Default.ModeLastest = true;
            WordJumble.Properties.Settings.Default.Mode = WordJumble.Properties.Settings.Default.Mode4Resume;
            WordJumble.Properties.Settings.Default.Save();
        }
    }
}
