namespace VersionAttribute
{
    using System;
    using System.Reflection;

    [Version(VersionAttribute.Type.Class, "TestAttribute", "2.11")]
    class TestAttribute
    {
        static void Main()
        {
            var attr = typeof(TestAttribute).GetCustomAttributes<VersionAttribute>();

            foreach (var attribute in attr)
            {
                Console.WriteLine("{0}: {1}     Version: {2}",
                    attribute.Component, attribute.Name, attribute.Version);
            }
        }
    }
}