using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        //any members of a class are reference types
        //structs are a value type, small amount of memory, more uncommon, kind of functions like a class 

        //if you're workng with a reference type, you can change the value of 

        //int is really struct Int32
        //double is really struct Double
        //book is struct Boolean
        
        [Fact]
        public void Test1(){
            var x = GetInt();

            // in order to get this test to pass, you need to use ref because ints are value types
            SetInt(ref x);

            Assert.Equal(42, x);
            
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
           return 3;
        }

        [Fact]
        public void CSharpCanPassByRef(){
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
             
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue(){
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
             
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

  
        [Fact]
        public void CanSetNameFromReference(){
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
             
        }

        private void SetName(Book book, string name){
            book.Name = name;
        }

        //strings are immutable
        //methods on a string return a new string that you need to return (see line 94 in MakeUpperCase method)
        [Fact]
        public void StringsBehaveLikeValueTypes(){
            string name = "Scott";
            var upper = MakeUpperCase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);

        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentBookObject(){   
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            

            //act


            //assert
           Assert.Equal("Book 1", book1.Name);
           Assert.Equal("Book 2", book2.Name);
           Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject(){
            var book1 = GetBook("Book 1");

            //takes value of book1 and copies it to book2
            var book2 = book1;
            Assert.Same(book1, book2);

            //same as assert.same
            Assert.True(object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name){
            
            return new Book(name);
        }
    }
}
