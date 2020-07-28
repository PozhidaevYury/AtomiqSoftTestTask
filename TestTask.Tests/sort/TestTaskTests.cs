using System;
using Xunit;
using System.Collections.Generic;

namespace TestTask.Tests
{
    public class TestTaskTests
    {
        [Fact]
        public void MethodIsCorrectWithValidData()
        {
            BaseTest test = new BaseTest();

            test
                .Setup()
                .SetupRule()
                .Sort()
                .AssertObjects();
        }

        [Fact]
        public void MethodIsCorrectWithEmptyList()
        {
            BaseTest test = new BaseTest();

            test
                .SetupWithEmptyList()
                .SetupRule()
                .AssertException();
        }

        [Fact]
        public void MethodIsCorrectWithInvalidColors()
        {
            BaseTest test = new BaseTest();

            test
                .SetupWithInvalidColors()
                .AssertException();
        }

        [Fact]
        public void MethodIsCorrectWithInvalidRule()
        {
            BaseTest test = new BaseTest();

            test
                .Setup()
                .SetupInvalidRule()
                .AssertObjects();
        }

        [Fact]
        public void MethodIsCorrectWithTwoColors()
        {
            BaseTest test = new BaseTest();

            test
                .SetupWithTwoColors()
                .SetupRule()
                .Sort()
                .AssertObjects();
        }

        [Fact]
        public void MethodIsCorrectWithOneColor()
        {
            BaseTest test = new BaseTest();

            test
                .SetupWithOneColor()
                .SetupRule()
                .Sort()
                .AssertObjects();
        }
       
    }
}
