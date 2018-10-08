using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Web;

namespace WebTests
{
    [TestClass]
    public class AutofacContainerTests
    {
        [TestMethod]
        public void Container_ContainsRepositories_SUCCESS()
        {
            IoCConfiguration.ConfigureContainer(); ;
            var container = IoCConfiguration.Container;
        }
    }
}
