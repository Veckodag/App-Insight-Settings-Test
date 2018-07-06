using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;

namespace InsightsSettingsTest.Models
{
    public class TelemetryViewModel
    {
        public TelemetryViewModel()
        {
            var myTelemetryClient = new TelemetryClient();
            //myTelemetryClient.Context.User.Id = "Fredrik";
            //UserName = myTelemetryClient.Context.User.Id;            

            // Set up some properties and metrics:
            var properties = new Dictionary<string, string>
                {{"game", "CurrentGameName"}, {"difficulty", "CurrentGameDifficulty"}};
            var metrics = new Dictionary<string, double>
                {{"Score", 10}, {"Opponents", 5}};

            // Send the event:
            myTelemetryClient.TrackEvent("Wow_Amazing_Telemetery", properties, metrics);

            SpecialProperties = properties;
            SpecialMetrics = metrics;
        }

        public string UserName { get; set; }
        public Dictionary<string, string> SpecialProperties { get; set; }
        public Dictionary<string, double> SpecialMetrics { get; set; }
    }
}
