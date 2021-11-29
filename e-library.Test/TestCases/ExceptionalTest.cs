using e_library.Test.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace e_library.Test.TestCases
{
    public class ExceptionalTest
    {
        /// <summary>
        /// Creating referance variable and injecting in constructor
        /// </summary>
        private readonly ITestOutputHelper _output;
        private Book _book;
        private Issue _issue;
        public ExceptionalTest(ITestOutputHelper output)
        {
            _output = output;
            _output = output;
            _book = new Book()
            {
                ISBN = "10029",
                BookName = "C in action",
                Issue = false,
                PublicationName = "M C Hill",
                Category = "Science"
            };
            _issue = new Issue()
            {
                ISBN = "10029",
                StudentName = "Uma Kumar",
                IssueDate = DateTime.Now
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// test for add book passed null should return null
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnNullOrNot()
        {
            //Arrange
            bool res = false;
            string testName;
            _book = null;
            List<Book> books = new List<Book>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                books = inventory.AddBook(_book);
                //Act
                if (books[0] == null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "testFor_AddNewBookReturnNullOrNot=" + res + "\n");
                return false;
            }
            ///Assert
            ///Write final test result
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "testFor_AddNewBookReturnNullOrNot=" + res + "\n");
            return res;
        }
    }
}
