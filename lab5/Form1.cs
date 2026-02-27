using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ClearInputFields()
        {
            txtAuthorName.Text = "";
            txtBookTitle.Text = "";
            txtBookID.Text = "";
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (var context = new BookstoreContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.Name == txtAuthorName.Text);
                if (author == null)
                {
                    author = new Author { Name = txtAuthorName.Text };
                    context.Authors.Add(author);
                }


                var book = new Book { Title = txtBookTitle.Text, Author = author };
                context.Books.Add(book);

                context.SaveChanges();
                MessageBox.Show("Book and Author added successfully!");
                ClearInputFields();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (var context = new BookstoreContext())
            {
                var books = context.Books.Include(b => b.Author).ToList();

                listBoxBooks.Items.Clear();
                foreach (var book in books)
                {
                    listBoxBooks.Items.Add($"ID: {book.BookID} | Title: {book.Title} | Author: {book.Author.Name}");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                using (var context = new BookstoreContext())
                {
                    var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);

                    if (book != null)
                    {
                        book.Title = txtBookTitle.Text;
                        book.Author.Name = txtAuthorName.Text;

                        context.SaveChanges();
                        MessageBox.Show("Book updated successfully!");

                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Book ID.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                using (var context = new BookstoreContext())
                {
                    var book = context.Books.Find(bookId);
                    if (book != null)
                    {
                        context.Books.Remove(book);
                        context.SaveChanges();
                        MessageBox.Show("Book deleted successfully!");

                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Book ID.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new BookstoreContext())
            {
                var authorName = txtAuthorName.Text;
                var books = context.Books
                                   .Include(b => b.Author)
                                   .Where(b => b.Author.Name.Contains(authorName))
                                   .ToList();

                listBoxBooks.Items.Clear();
                foreach (var book in books)
                {
                    listBoxBooks.Items.Add($"ID: {book.BookID} | Title: {book.Title} | Author: {book.Author.Name}");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void txtBookTitle_TextChanged(object sender, EventArgs e) { }

        private void btnFollowUpQuestion_Click(object sender, EventArgs e)
        {
            string message = "1. How does database integration improve the functionality of your software?\n\n" +
                     "Answer: Database integration improves software functionality by providing permanent data storage, meaning data is saved even after the application is closed. It allows the software to efficiently organize, search, and filter information while ensuring data integrity.\n\n" +
                     "--------------------------------------------------\n\n" +
                     "2. What are the key components of CRUD operations?\n\n" +
                     "Answer:\n" +
                     "• Create: Adding new records (e.g., adding a new book).\n" +
                     "• Read: Retrieving existing data (e.g., showing the list of books).\n" +
                     "• Update: Modifying existing records (e.g., changing a book's title).\n" +
                     "• Delete: Removing specific records permanently (e.g., deleting a book).";

            MessageBox.Show(message, "Lab Questions & Answers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
    }
}