﻿namespace AuthorProblem
{
    using System;
    using System.Linq;
    using System.Reflection;
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type classType = typeof(StartUp);

            MethodInfo[] methods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

            foreach (MethodInfo method in methods)
            {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(false);
                    foreach (AuthorAttribute attribute in attributes)
                    {
                        Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                    }
                }
            }
        }
    }
}
