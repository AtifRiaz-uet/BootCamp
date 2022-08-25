using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PenaltyProject.DataLayer;
using PenaltyProject.Models;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;

namespace PenaltyProject.BusinessLayer
{
    public class PenaltyCalculator :IPenaltyCalculator
    {
        ISqlData _content;

        public PenaltyCalculator(ISqlData content)
        {
            _content = content;
        }

        public List<Country> GetCountries()
        {
            return _content.GetCountries();
        }

        public List<double> GetDays(datesModel dates)
        {
            string CalendarID;
            List<double> dayPenaltyList;

            if (dates.countryName == "UAE")
            {
                CalendarID = "en-gb.ae.official#holiday@group.v.calendar.google.com";
            }
            else
            {
                CalendarID = "en-gb.pk#holiday@group.v.calendar.google.com";
            }
            List<SpecialDays> specialDates = GetSpecialDays(CalendarID);
            int day = 1;

            while ((dates.checkIn).Date != (dates.checkOut).Date)
            {
                SpecialDays newdays = new SpecialDays();
                newdays.date = dates.checkIn;

                if ((dates.checkIn).DayOfWeek.ToString() == "Saturday" || (dates.checkIn).DayOfWeek.ToString() == "Sunday" || specialDates.Contains(newdays))
                {
                    // Do Nothing
                }
                else
                {
                    Console.WriteLine($"{(dates.checkIn).Date.ToString("yyyy-MM-dd")}:{(dates.checkIn).DayOfWeek.ToString()}");
                    day++;
                }
                (dates.checkIn) = (dates.checkIn).AddDays(1);
            }
            if (day>10)
            {
                double penalty = CalculatePenalty(day, dates.countryName);
                dayPenaltyList = new List<double> { day, penalty };
            }
            else
            {
                double penalty = 0;
                dayPenaltyList = new List<double> { day, penalty };
            }
            
            return dayPenaltyList;
        }

        private List<SpecialDays> GetSpecialDays(string CalendarID)
        {
            List<SpecialDays> specialDaysList = new List<SpecialDays>();
            const string apiKey = "AIzaSyCkHEq9efc73mgl0k3Ib7wwI54Gle5hX3M";
            string calendar = CalendarID;


            static async Task Main(string[] args, List<SpecialDays> specialDaysList,string  CalendarID)
            {
                Console.WriteLine("Just Checking");

                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    ApiKey = apiKey,
                    ApplicationName = "Penalty Calculator"
                });
                var request = service.Events.List(CalendarID);
                request.Fields = "items(summary,start,end)";
                var response = await request.ExecuteAsync();
                foreach (var item in response.Items)
                {
                    Console.WriteLine($"Holiday: {item.Summary} start: {item.Start.Date} End: {item.End.Date}");

                    SpecialDays days = new SpecialDays();
                    days.date = DateTime.Parse(item.Start.Date);
                    specialDaysList.Add(days);

                }
                Console.ReadLine();


            }
            return specialDaysList;
        }

        private double CalculatePenalty(int days,string country)
        {
            List<Country> countries = _content.GetCountries();
            int uaePenalty;
            int pakPenalty;
            uaePenalty = (countries[1].penalty);
            pakPenalty = (countries[0].penalty);
            if (country =="UAE")
            {
                return days * uaePenalty;
            }
            else
            {
                return days * pakPenalty;
            }
        }
    }


}
