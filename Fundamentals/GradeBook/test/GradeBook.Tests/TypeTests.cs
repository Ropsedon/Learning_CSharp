using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact] // atribute
        public void CSharpValues()
        {
            // arrange - contains variables or conditions
            var x = GetValue();
            // act - contains conditions of the execution

            // assert - compare actual and expected result
            Assert.Equal(x, 3);
        }

        private int GetValue()
        {
            return 3;
        }

        [Fact] // atribute
        public void CSharpIsPassByValueCanRef()
        {
            // arrange - contains variables or conditions
            var book1 = GetBook("Book 1");
            GetBookSetNameRef(ref book1, "New Name");

            // act - contains conditions of the execution

            // assert - compare actual and expected result
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNameRef(ref Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact] // atribute
        public void CSharpIsPassByValue()
        {
            // arrange - contains variables or conditions
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // act - contains conditions of the execution

            // assert - compare actual and expected result
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }
        
        [Fact] // atribute
        public void CanSetNameFromRafarence()
        {
            // arrange - contains variables or conditions
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // act - contains conditions of the execution

            // assert - compare actual and expected result
            Assert.NotSame("Book 1", book1.Name);
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book1, string name)
        {
            book1.Name = name;
        }
        
        [Fact] // atribute
        public void GetBookReturnsDifferentObjects()
        {
            // arrange - contains variables or conditions
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act - contains conditions of the execution

            // assert - compare actual and expected result
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // arrange - contains variables or conditions
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // act - contains conditions of the execution

            // assert - compare actual and expected result
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }


    }
}
