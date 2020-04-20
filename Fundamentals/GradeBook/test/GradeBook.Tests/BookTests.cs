using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] // atribute
        public void BookCalculatesAnAverageGrade()
        {
            // arrange - contains variables or conditions
            var a = 5;
            var b = 7;
            var expected = 12;

            // act - contains conditions of the execution
            var actual = a + b;

            // assert - compare actual and expected result
            Assert.Equal(expected, actual);
        }

        [Fact] // atribute
        public void Test2()
        {
            // arrange - contains variables or conditions
            var book = new Book("");
            book.AddGrades(77.01);
            book.AddGrades(89.02);
            book.AddGrades(92.03);

            // act - contains conditions of the execution
            var result = book.GetStatistic();

            // assert - compare actual and expected result
            Assert.Equal(86.02, result.Average, 2);
            Assert.Equal(92.03, result.High);
            Assert.Equal(77.01, result.Low);
        }

        // [Fact] // atribute
        // public void ValidateValue()
        // {
        //     // arrange - contains variables or conditions
        //     var book = new Book("");
        //     book.AddGrades(100.01);

            // act - contains conditions of the execution

            // assert - compare actual and expected result
        }
    }
}
