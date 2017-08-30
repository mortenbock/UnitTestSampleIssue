using System;
using Newtonsoft.Json;

namespace UnitTestSampleIssue.NewDependency
{
    public class New
    {
        public static Version NewtonVersion()
        {
            return typeof(JsonSerializerSettings).Assembly.GetName().Version;
        }
    }
}
