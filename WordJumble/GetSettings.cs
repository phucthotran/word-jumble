using System;
using System.Text;

namespace WordJumble
{
    public class ModeSettings
    {        
        private static int _winTimes; //Win times to bonus
        private static int _wrongTimes; //Wrong times limit
        private static int _point; //Point for each win times
        private static int _bonus; //Bonus for Win times (follow Rule)
        private static int _missed; //Each missed, subtract x point (follow Rule)

        public static int WinTimesToBonus { get { return _winTimes; } set { _winTimes = value; } }
        public static int WrongTimesLimit { get { return _wrongTimes; } set { _wrongTimes = value; } }
        public static int WinPoint { get { return _point; } set { _point = value; } }
        public static int BonusPoint { get { return _bonus; } set { _bonus = value; } }
        public static int SubtractPoint { get { return _missed; } set { _missed = value; } }

        /// <summary>
        /// Save all settings
        /// </summary>
        public static void SaveSettings()
        {            
            WordJumble.Properties.Settings.Default.WinTimes = WinTimesToBonus;
            WordJumble.Properties.Settings.Default.WrongTimes = WrongTimesLimit;
            WordJumble.Properties.Settings.Default.Point = WinPoint;
            WordJumble.Properties.Settings.Default.Bonus = BonusPoint;
            WordJumble.Properties.Settings.Default.Missed = SubtractPoint;
            WordJumble.Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Setup all settings for play mode
        /// </summary>
        /// <param name="WinTime">Win times to bonus</param>
        /// <param name="WrongTime">Wrong time limit</param>
        /// <param name="Point">Point for each win times (base on play mode)</param>
        /// <param name="Bonus">Bonus for win times (base on play mode)</param>
        /// <param name="Missed">Each missed times, subtract x point (base on play mode)</param>
        public static void SetUp(int WinTime, int WrongTime, int Point, int Bonus, int Missed)
        {
            _winTimes = WinTime;
            _wrongTimes = WrongTime;
            _point = Point;
            _bonus = Bonus;
            _missed = Missed;            
        }
    }

    public class ResumeSettings
    {
        private static int _winTimes;
        private static int _totalWin;
        private static int _point;
        private static int _bonus;
        private static int _missed;
        private static int _prepareBonus;
        private static int _hintLimit;
        private static int _changeLimit;
        private static int _reduceLimit;

        public static int WinTimes { get { return _winTimes; } set { _winTimes = value; } }
        public static int TotalWin { get { return _totalWin; } set { _totalWin = value; } }
        public static int Point { get { return _point; } set { _point = value; } }
        public static int Bonus { get { return _bonus; } set { _bonus = value; } }
        public static int Missed { get { return _missed; } set { _missed = value; } }
        public static int PrepareBonus { get { return _prepareBonus; } set { _prepareBonus = value; } }
        public static int HintLimit { get { return _hintLimit; } set { _hintLimit = value; } }
        public static int ChangeQuestionLimit { get { return _changeLimit; } set { _changeLimit = value; } }
        public static int ReduceLimit { get { return _reduceLimit; } set { _reduceLimit = value; } }

        /// <summary>
        /// Save all settings
        /// </summary>
        public static void SaveSettings()
        {
            WordJumble.Properties.Settings.Default.Point4Resume = _point;
            WordJumble.Properties.Settings.Default.Bonus4Resume = _bonus;
            WordJumble.Properties.Settings.Default.Missed4Resume = _missed;
            WordJumble.Properties.Settings.Default.WinTimes4Resume = _winTimes;
            WordJumble.Properties.Settings.Default.TotalWin4Resume = _totalWin;
            WordJumble.Properties.Settings.Default.PrepareBonus = _prepareBonus;
            WordJumble.Properties.Settings.Default.HintLimit = _hintLimit;
            WordJumble.Properties.Settings.Default.ChangQuestionLimit = _changeLimit;
            WordJumble.Properties.Settings.Default.ReduceLimit = _reduceLimit;
            WordJumble.Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Setup all settings for resume mode (Customize)
        /// </summary>
        /// <param name="Point">Point to save</param>
        /// <param name="Bonus">Bonus to save</param>
        /// <param name="Missed">Missed to save</param>
        /// <param name="WinTimes">Win times to save</param>
        /// <param name="TotalWin">Total win to save</param>
        /// <param name="PrepareBonus">Prepare bonus to save</param>
        /// <param name="HintLimit">Hint limit to save</param>
        /// <param name="ChangeQuestionLimit">Change question limit to save</param>
        /// <param name="ReduceLimit">Reduce limit to save</param>
        public static void SetUp(int Point, int Bonus, int Missed, int WinTimes, int TotalWin, int PrepareBonus, int HintLimit, int ChangeQuestionLimit, int ReduceLimit)
        {
            _point = Point;
            _bonus = Bonus;
            _missed = Missed;
            _winTimes = WinTimes;
            _totalWin = TotalWin;
            _prepareBonus = PrepareBonus;
            _hintLimit = HintLimit;
            _changeLimit = ChangeQuestionLimit;
            _reduceLimit = ReduceLimit;
        }
        
        /// <summary>
        /// Setup all settings for resume mode
        /// </summary>
        public static void SetUp()
        {
            _point = WordJumble.Properties.Settings.Default.Point4Resume;
            _bonus = WordJumble.Properties.Settings.Default.Bonus4Resume;
            _missed = WordJumble.Properties.Settings.Default.Missed4Resume;
            _winTimes = WordJumble.Properties.Settings.Default.WinTimes4Resume;
            _totalWin = WordJumble.Properties.Settings.Default.TotalWin4Resume;
            _prepareBonus = WordJumble.Properties.Settings.Default.PrepareBonus;
            _hintLimit = WordJumble.Properties.Settings.Default.HintLimit;
            _changeLimit = WordJumble.Properties.Settings.Default.ChangQuestionLimit;
            _reduceLimit = WordJumble.Properties.Settings.Default.ReduceLimit;
        }
    }

    public class SaveScoresSettings
    {
        private static int _point;
        private static int _bonus;
        private static int _missed;
        private static int _time;

        public static int Time { get { return _time; } set { _time = value; } }
        public static int Point { get { return _point; } set { _point = value; } }
        public static int Bonus { get { return _bonus; } set { _bonus = value; } }
        public static int Missed { get { return _missed; } set { _missed = value; } }

        /// <summary>
        /// Save all settings for save scores
        /// </summary>
        public static void SaveSettings()
        {
            WordJumble.Properties.Settings.Default.Time4Save = _time;
            WordJumble.Properties.Settings.Default.Point4Save = _point;
            WordJumble.Properties.Settings.Default.Bonus4Save = _bonus;
            WordJumble.Properties.Settings.Default.Missed4Save = _missed;
            WordJumble.Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Setup all settings for save scores
        /// </summary>
        /// <param name="Time">Time was play (If play mode is "Time Limited")</param>
        /// <param name="Point">Point was play</param>
        /// <param name="Bonus">Bonus was play</param>
        /// <param name="Missed">Missed times</param>
        public static void SetUp(int Time, int Point, int Bonus, int Missed)
        {
            if (WordJumble.Properties.Settings.Default.Mode != "Time Limited")
                _time = 0;
            else
                _time = Time;

            _point = Point;
            _bonus = Bonus;
            _missed = Missed;
        }
    }
}
