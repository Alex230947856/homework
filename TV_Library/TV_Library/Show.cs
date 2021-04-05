using System;

namespace TV_Library
{
    public class Show
    {
        public string ProgramTV;
        public string Host;
        public string Description;
        public FrequencyTypes Period;
        public DateTime ReleaseDate;
        public string GetReleaseDate
        {
            get
            {
                string answer = "";
                if (Period == FrequencyTypes.NonPeriodic)
                {
                    answer = ReleaseDate.ToUniversalTime().AddHours(5).ToString();
                    return answer.Substring(0, answer.Length - 3);
                } 
                else return ReleaseDate.ToShortTimeString();
            }
        }

        public Show(string programTV, string host, string description, FrequencyTypes period, string releaseDate)
        {
            ProgramTV = programTV;
            Host = host;
            Description = description;
            Period = period;
            ReleaseDate = DateTime.Parse(releaseDate);
        }

        public override string ToString()
        {
            return $"{ProgramTV}, {Host}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var period = "";
            switch (Period)
            {
                case FrequencyTypes.Daily:
                    period = "ежедневно";
                    break;
                case FrequencyTypes.Weekly:
                    period = "еженедельно";
                    break;
                case FrequencyTypes.Monthly:
                    period = "ежемесячно";
                    break;
                case FrequencyTypes.NonPeriodic:
                    period = "не указана";
                    break;
            }

            Console.WriteLine($"Описание программы: {Description}. Частота: {period}. Дата выхода: {GetReleaseDate}.");
        }

    }
}
