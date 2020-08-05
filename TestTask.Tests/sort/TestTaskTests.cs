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
            SortMethod method = new SortMethod();

            method
                .SetupObjects()
                .SetupRule()
                .Sort()
                .AssertSort();
        }

        [Fact]
        public void MethodIsCorrectWithEmptyList()
        {
            SortMethod method = new SortMethod();

            method
                .SetupWithEmptyList()
                .SetupRule()
                .AssertException();
        }

        [Fact]
        public void MethodIsCorrectWithInvalidColors()
        {
            SortMethod method = new SortMethod();

            method
                .SetupWithInvalidColors()
                .AssertException();
        }

        [Fact]
        public void MethodIsCorrectWithInvalidRule()
        {
            SortMethod method = new SortMethod();

            method
                .SetupObjects()
                .SetupInvalidRule()
                .AssertException();
        }

        [Fact]
        public void MethodIsCorrectWithTwoColors()
        {
            SortMethod method = new SortMethod();

            method
                .SetupWithTwoColors()
                .SetupRule()
                .Sort()
                .AssertSort();
        }

        [Fact]
        public void MethodIsCorrectWithOneColor()
        {
            SortMethod method = new SortMethod();

            method
                .SetupWithOneColor()
                .SetupRule()
                .Sort()
                .AssertSort();
        }
       
    }
}
