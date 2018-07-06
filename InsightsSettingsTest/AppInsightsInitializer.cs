using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InsightsSettingsTest
{
    public class AppInsightsInitializer : ITelemetryInitializer
    {
        //Example of how to set up the ITelemetry with a custom value
        //This is serverside
        public void Initialize(ITelemetry telemetry)
        {
            //The point is setting the Auth user Id to something
            //if (Thread.CurrentPrincipal != null &&
            //    Thread.CurrentPrincipal.Identity != null)
            //{
            //    telemetry.Context.User.AuthenticatedUserId =
            //                  Thread.CurrentPrincipal.Identity.Name;
            //}
            telemetry.Context.User.AuthenticatedUserId = "ThisIsSetInTheCSharpCode";
        }
    }
}
