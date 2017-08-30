using System;
using Newtonsoft.Json;

namespace UnitTestSampleIssue.OldDependency
{
    public class Old
    {
        public static Version NewtonVersion()
        {
            return typeof(JsonSerializerSettings).Assembly.GetName().Version;
        }
    }
}
