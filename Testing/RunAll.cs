using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace SpookifyApi.Tests
{
    public class CustomTestRunner
    {
        public void RunAllTestsInAssembly()
        {
            var testAssembly = Assembly.GetExecutingAssembly();
            var testFixtures = testAssembly.GetTypes()
                .Where(t => t.GetCustomAttributes(typeof(TestFixtureAttribute), true).Length > 0)
                .ToList();

            foreach (var testFixture in testFixtures)
            {
                Console.WriteLine($"Running tests in: {testFixture.Name}");
                var fixtureInstance = Activator.CreateInstance(testFixture);
                var testMethods = testFixture.GetMethods()
                    .Where(m => m.GetCustomAttributes(typeof(TestAttribute), true).Length > 0)
                    .ToList();

                foreach (var method in testMethods)
                {
                    try
                    {
                        method.Invoke(fixtureInstance, null);
                        Console.WriteLine($"PASSED: {method.Name}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"FAILED: {method.Name} - Exception: {ex.InnerException?.Message}");
                    }
                }
            }
        }
    }
}
