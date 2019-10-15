using System;
using Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPolicyASingleton()
        {
            Assert.AreSame(Policy.Instance, Policy.Instance);
            //so... whyyyy is the code not recognizing using Singleton? :(
            //anyway, this test will only pass if you've made a true singleton
            //otherwise, it will compare two non-same instances.
        }
    }
}
