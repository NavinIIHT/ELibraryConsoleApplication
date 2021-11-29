using e_library.Test.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace e_library.Test.TestCases
{
    public class BoundaryTest
    {
        private readonly ITestOutputHelper _output;
        private Book _book;
        private Issue _issue;
        public BoundaryTest(ITestOutputHelper output)
        {
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
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test for book ISBN is correct or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnBookISBN()
        {
            //Arrange
            bool res = false;
            string testName;
            List<Book> books = new List<Book>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                books = inventory.AddBook(_book);
                //Act
                foreach(var book in books)
                {
                    if(book.ISBN == _book.ISBN)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnBookISBN=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnBookISBN=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for bookName is correct or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnBookName()
        {
            //Arrange
            bool res = false;
            string testName;
            List<Book> books = new List<Book>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                books = inventory.AddBook(_book);
                //Act
                foreach (var book in books)
                {
                    if (book.BookName == _book.BookName)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnBookName=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnBookName=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Issue is correct or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnIssue()
        {
            //Arrange
            bool res = false;
            string testName;
            List<Book> books = new List<Book>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                books = inventory.AddBook(_book);
                //Act
                foreach (var book in books)
                {
                    if (book.Issue == _book.Issue)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnIssue=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnIssue=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for PublicationName is correct or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnPublicationName()
        {
            //Arrange
            bool res = false;
            string testName;
            List<Book> books = new List<Book>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                books = inventory.AddBook(_book);
                //Act
                foreach (var book in books)
                {
                    if (book.PublicationName == _book.PublicationName)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnPublicationName=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnPublicationName=" + res + "\n");
            return res;
        }
        /// <summary>
        /// test for Category return correct or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnCategory()
        {
            //Arrange
            bool res = false;
            string testName;
            List<Book> books = new List<Book>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                books = inventory.AddBook(_book);
                //Act
                foreach (var book in books)
                {
                    if (book.Category == _book.Category)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnCategory=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnCategory=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Issue ISBN is correct or Not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnIssue_ISBN()
        {
            //Arrange
            bool res = false;
            string testName;
            List<Issue> issues = new List<Issue>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                inventory.AddBook(_book);
                issues = inventory.IssueBook(_issue);
                //Act
                foreach (var issue in issues)
                {
                    if (issue.ISBN == _issue.ISBN)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnIssue_ISBN=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnIssue_ISBN=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for student name in Issue return true or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnIssue_StudentName()
        {
            //Arrange
            bool res = false;
            string testName;
            List<Issue> issues = new List<Issue>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                inventory.AddBook(_book);
                issues = inventory.IssueBook(_issue);
                //Act
                foreach (var issue in issues)
                {
                    if (issue.StudentName == _issue.StudentName)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnIssue_StudentName=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnIssue_StudentName=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test for Issue Date in Issue return true or not.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> testFor_AddNewBookReturnIssue_IssueDate()
        {
            //Arrange
            bool res = false;
            string testName;
            List<Issue> issues = new List<Issue>();
            testName = TestAPI.GetCurrentMethodName();
            BookInventory inventory = new BookInventory();
            try
            {
                inventory.AddBook(_book);
                issues = inventory.IssueBook(_issue);
                //Act
                foreach (var issue in issues)
                {
                    if (issue.IssueDate == _issue.IssueDate)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                ///Write test result if any exception occur
                _output.WriteLine(testName + ":Failed");
                await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnIssue_IssueDate=" + res + "\n");
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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "testFor_AddNewBookReturnIssue_IssueDate=" + res + "\n");
            return res;
        }
    }
}
