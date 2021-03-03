using System;
using System.Collections.Generic;
using System.Text;

namespace covid.Core.Entities
{
    public class Overview
    {
        public Overview(string date, int totalTests, int totalCases, int activeCases, int totalDeaths, int totalHealths, int currentHospitalized, int tomorrowTests, int tomorrowCases, int totalVaccination, int tomorowVaccination)
        {
            Date = date;
            TotalTests = totalTests;
            TotalCases = totalCases;
            ActiveCases = activeCases;
            TotalDeaths = totalDeaths;
            TotalHealths = totalHealths;
            CurrentHospitalized = currentHospitalized;
            TomorrowTests = tomorrowTests;
            TomorrowCases = tomorrowCases;
            TotalVaccination = totalVaccination;
            TomorowVaccination = tomorowVaccination;
        }

        public string Date { get; }
        public int TotalTests { get; }
        public int TotalCases { get; }
        public int ActiveCases { get; }
        public int TotalDeaths { get; }
        public int TotalHealths { get; }
        public int CurrentHospitalized { get; }
        public int TomorrowTests { get; }
        public int TomorrowCases { get; }
        public int TotalVaccination { get; }
        public int TomorowVaccination { get; }
    }
}
