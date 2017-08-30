using System;
using System.Configuration;
using NUnit.Framework;
using UnitTestSampleIssue.NewDependency;
using UnitTestSampleIssue.OldDependency;

namespace UnitTestSampleIssue.App.Tests
{
    [TestFixture]
    public class AssemblyTesting
    {
        [Test]
        public void VerifyThatAppConfigIsCorrect()
        {
            var appSetting = ConfigurationManager.AppSettings["mysetting"];
            Assert.That(appSetting, Is.EqualTo("myvalue"));
        }

        [Test]
        public void VerifyOldVersionIs6()
        {
            Assert.That(Old.NewtonVersion().Major, Is.EqualTo(6));
        }

        [Test]
        public void VerifyNewVersionIs10()
        {
            Assert.That(New.NewtonVersion().Major, Is.EqualTo(10));
        }

        [Test]
        public void VerifyAppBaseIsCorrect()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            StringAssert.Contains("UnitTestSampleIssue.App.Tests\\bin\\Debug", baseDirectory);
        }
    }
}
