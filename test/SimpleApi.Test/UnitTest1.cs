using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class UnitTest1
    {

        ValuesController vc = new ValuesController();

        [Fact]
        public void WhenValueMatchWithReturnValue() {
            var returnValue = vc.Get(5);
            Assert.Equal("Value returned is : 5", returnValue.Value);
        }

        [Fact]
        public void WhenValueDoesNotMatchWithReturnValue() {
            var returnValue = vc.Get(6);
            Assert.Equal("Value returned is : 6", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
