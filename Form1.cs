using System.Diagnostics;
using System.Globalization;

namespace period_calc
{
    public partial class Form1 : Form
    {
        private List<Holiday> currentHolidays = new List<Holiday>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numYear.Value = DateTime.Now.Year;
            LoadHolidaysFromFile();
            ReadHolidays();

            var periods = GeneratePeriods((int)numYear.Value);
            var total = 0;
            foreach (var period in periods)
            {
                var periodTotal = CalculateForPeriod(period.From, period.To, false);
                rtpOutput.AppendText($"{period.From} - {period.To} : {periodTotal}\n");
                total += periodTotal;
            }
            rtpOutput.AppendText($"Yearly total: {total}\n");

            lbPeriods.Items.Clear();
            lbPeriods.DisplayMember = "Display";
            lbPeriods.Items.AddRange(periods.ToArray());

        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {
            rtpOutput.Clear();
            var periods = GeneratePeriods((int)numYear.Value);
            foreach (var period in periods)
            {
                var totalHours = CalculateForPeriod(period.From, period.To, false);
                rtpOutput.AppendText($"{period.From} - {period.To} : {totalHours}\n");
            }
        }

        private void lbPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lbPeriods.SelectedItem as DateRange;
            CalculateForPeriod(item.From, item.To);

        }
        private void btnReadHolidays_Click(object sender, EventArgs e)
        {
            ReadHolidays();
        }

        private void ReadHolidays()
        {
            currentHolidays.Clear();
            foreach (string line in tbHolydays.Lines.Where(l => !string.IsNullOrWhiteSpace(l)))
            {
                var p = line.Split(' ', 2);
                if (p.Length == 2)
                {
                    if (DateOnly.TryParse(p[0], out var date))
                        currentHolidays.Add(Holiday.Create(date, p[1]));
                }
            }
            lblHolidaysUsed.Text = $"Holidays Used: {currentHolidays.Count}";
            lbHolidaysUsed.Items.Clear();
            lbHolidaysUsed.DisplayMember = "Display";
            lbHolidaysUsed.Items.AddRange(currentHolidays.ToArray());
        }

        private void LoadHolidaysFromFile()
        {
            tbHolydays.Clear();
            if (File.Exists("ledigadagar.csv"))
            {
                var days = File.ReadAllLines("ledigadagar.csv");
                foreach (var day in days)
                {
                    if (!string.IsNullOrEmpty(day))
                    {
                        var ds = day.Split('\t');
                        tbHolydays.AppendText($"{ds[0]} {ds[1]}\r\n");
                    }
                }
            }
        }

        private List<DateRange> GeneratePeriods(int year)
        {
            //2024-12-21 - 2025-01-20
            //2025-01-21 - 2025-02-20
            //2025-02-21 - 2025-03-20
            var periods = new List<DateRange>();
            periods.Add(DateRange.Create(year - 1, 12, 21, year, 01, 20));
            periods.Add(DateRange.Create(year, 01, 21, year, 02, 20));
            periods.Add(DateRange.Create(year, 02, 21, year, 03, 20));
            periods.Add(DateRange.Create(year, 03, 21, year, 04, 20));
            periods.Add(DateRange.Create(year, 04, 21, year, 05, 20));
            periods.Add(DateRange.Create(year, 05, 21, year, 06, 20));
            periods.Add(DateRange.Create(year, 06, 21, year, 07, 20));
            periods.Add(DateRange.Create(year, 07, 21, year, 08, 20));
            periods.Add(DateRange.Create(year, 08, 21, year, 09, 20));
            periods.Add(DateRange.Create(year, 09, 21, year, 10, 20));
            periods.Add(DateRange.Create(year, 10, 21, year, 11, 20));
            periods.Add(DateRange.Create(year, 11, 21, year, 12, 20));

            return periods;
        }
        private int CalculateForPeriod(DateOnly start, DateOnly end, bool report = true)
        {
            if (report)
            {
                rtpOutput.Clear();
                rtpOutput.AppendText($"Calculation period: {start} - {end}\n");
            }

            int totalHours = 0; // Counter for total hours, coomment test
            int currentWeek = 0;
            int currentMonth = start.Month;
            // Iterate from start to end
            for (var date = start; date <= end; date = date.AddDays(1))
            {
                if (report && currentMonth != date.Month)
                {
                    rtpOutput.AppendText($"\t\t100:00:00\t\t{date.ToString("MMMM").ToUpper()}\n");
                    currentMonth = date.Month;
                }

                bool isWeekend = date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
                string star = isWeekend ? "*" : "";

                var holiday = currentHolidays.FirstOrDefault(h => h.Date == date);
                bool isHoliday = holiday != null && cbHolidaysUsed.Checked;

                if (!isWeekend && !isHoliday)
                {
                    totalHours += 8;
                }

                if (report)
                {
                    if (isWeekend && !cbShowWeekends.Checked)
                        continue;

                    var cwn = ISOWeek.GetWeekOfYear(date.ToDateTime(TimeOnly.MinValue));
                    var weekToShow = string.Empty;
                    if (cwn != currentWeek)
                    {
                        currentWeek = cwn;
                        weekToShow = cwn.ToString();
                    }
                    else
                    {
                        weekToShow = string.Empty;
                    }

                    var holidayString = isHoliday ? holiday.Name : string.Empty;

                    var timeString = isHoliday ? "00:00:00" : "08:00:00";
                    rtpOutput.AppendText($"{weekToShow}\t{date}\t{timeString}\t{date.DayOfWeek} {star}{holidayString}\n");
                }
            }
            if (report)
            {
                rtpOutput.AppendText($"Total hours for period: {totalHours}\n");
            }
            return totalHours;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtpOutput.Clear();
            Form1_Load(sender, e);
        }
    }

    [DebuggerDisplay("{Display}")]
    public class DateRange
    {
        public DateOnly From { get; set; }
        public DateOnly To { get; set; }
        public string Display => $"{From} - {To}";

        public static DateRange Create(int fyear, int fmonth, int fday, int tyear, int tmonth, int tday)
        {
            return new DateRange
            {
                From = new DateOnly(fyear, fmonth, fday),
                To = new DateOnly(tyear, tmonth, tday)
            };
        }
    }

    [DebuggerDisplay("{Display}")]
    public class Holiday
    {
        public DateOnly Date { get; set; }
        public string Name { get; set; }
        public string Display => $"{Date} {Name}";
        public static Holiday Create(DateOnly date, string name)
        {
            return new Holiday
            {
                Date = date,
                Name = name
            };
        }
    }
}
