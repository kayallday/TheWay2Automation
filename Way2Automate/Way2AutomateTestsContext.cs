﻿using System;
using NUnit.Framework;

namespace Way2AutomateTests
{
    [TestFixture]
    public class Way2AutomateTestsContext
    {
        public static TestContext Context { get; private set; }

        public static void AssemblyInit(TestContext context)
        {
            Context = context;
        }
    }
}