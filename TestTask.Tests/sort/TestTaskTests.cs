using System;
using Xunit;

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
                .SortEmptyList();
        }
     
        [Fact]
        public void MethodThrowExceptionWithInvalidColors()
        {
            SortMethod method = new SortMethod();
     
            method
                .SetupWithInvalidColors()
                .SetupRule()
                .AssertExceptionSort();
        }
     
        [Fact]
        public void MethodThrowExceptiontWithInvalidRule()
        {
            SortMethod method = new SortMethod();
     
            method
                .SetupObjects()
                .SetupInvalidRule()
                .AssertExceptionSort();
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

        [Fact]
        public void MethodThrowEceptionWithSameColorInRule()
        {
            SortMethod method = new SortMethod();

            method
                .SetupObjects()
                .SetupRuleWithSameColors()
                .AssertExceptionSort();
        }

        [Fact]
        public void MethodIsCorrectWithBigList()
        {
            SortMethod method = new SortMethod();

            method
                .SetupWithBigList()
                .SetupRule()
                .Sort()
                .AssertSort();
        }
       
    }
}
