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
            SortTest test = new SortTest();

            test
                .Setup()
                .SetupRule()
                .Sort()
                .AssertObjects();
        }

        [Fact]
        public void MethodIsCorrectWithEmptyList()
        {
            SortTest test = new SortTest();

            test
                .SetupWithEmptyList()
                .SetupRule()
                .AssertException();
        }

        [Fact]
        public void MethodIsCorrectWithInvalidColors()
        {
            SortTest test = new SortTest();

            test
                .SetupWithInvalidColors()
                .AssertException();
        }

        [Fact]
        public void MethodIsCorrectWithInvalidRule()
        {
            SortTest test = new SortTest();

            test
                .Setup()
                .SetupInvalidRule()
                .AssertObjects();
        }

        [Fact]
        public void MethodIsCorrectWithTwoColors()
        {
            SortTest test = new SortTest();

            test
                .SetupWithTwoColors()
                .SetupRule()
                .Sort()
                .AssertObjects();
        }

        [Fact]
        public void MethodIsCorrectWithOneColor()
        {
            SortTest test = new SortTest();

            test
                .SetupWithOneColor()
                .SetupRule()
                .Sort()
                .AssertObjects();
        }
       
    }
}
