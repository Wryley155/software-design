using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6;
using Microsoft.EntityFrameworkCore;

namespace lab6
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

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            btnAddBook.Enabled = false;

            using (var context = new BookstoreContext())
            {
                var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == txtAuthorName.Text);
                if (author == null)
                {
                    author = new Author { Name = txtAuthorName.Text };
                    await context.Authors.AddAsync(author);
                }

                var book = new Book { Title = txtBookTitle.Text, Author = author };
                await context.Books.AddAsync(book);

                await context.SaveChangesAsync();
                MessageBox.Show("Book and Author added asynchronously!");
                ClearInputFields();

                btnShow_Click(sender, e);
            }

            btnAddBook.Enabled = true;
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(percent =>
            {
                progressBar1.Value = percent;
            });

            progressBar1.Value = 0;
            btnShow.Enabled = false;

            await LoadBooksWithProgressAsync(progress);

            btnShow.Enabled = true;
        }

        private async Task LoadBooksWithProgressAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                progress.Report(25);
                await Task.Delay(500);

                var books = await context.Books.Include(b => b.Author).ToListAsync();

                progress.Report(75);
                await Task.Delay(500);

                listBoxBooks.Items.Clear();
                foreach (var book in books)
                {
                    listBoxBooks.Items.Add($"ID: {book.BookID} | Title: {book.Title} | Author: {book.Author.Name}");
                }

                progress.Report(100);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                using (var context = new BookstoreContext())
                {
                    var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookId);

                    if (book != null)
                    {
                        book.Title = txtBookTitle.Text;
                        book.Author.Name = txtAuthorName.Text;

                        await context.SaveChangesAsync();
                        MessageBox.Show("Book updated asynchronously!");
                        ClearInputFields();

                        btnShow_Click(sender, e);
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                using (var context = new BookstoreContext())
                {
                    var book = await context.Books.FindAsync(bookId);
                    if (book != null)
                    {
                        context.Books.Remove(book);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Book deleted asynchronously!");
                        ClearInputFields();

                        btnShow_Click(sender, e);
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new BookstoreContext())
            {
                var searchTitle = txtBookTitle.Text;

                var books = await context.Books
                                         .Include(b => b.Author)
                                         .Where(b => b.Title.Contains(searchTitle))
                                         .ToListAsync();

                listBoxBooks.Items.Clear();
                if (books.Any())
                {
                    foreach (var book in books)
                    {
                        listBoxBooks.Items.Add($"ID: {book.BookID} | Title: {book.Title} | Author: {book.Author.Name}");
                    }
                }
                else
                {
                    listBoxBooks.Items.Add("No books found with that title.");
                }
            }
        }

        private void btnFollowUpQ_Click(object sender, EventArgs e)
        {
            string answers = "1. How does event-driven programming improve user interaction in an application?\n" +
                     "Answer: It allows the program to react instantly to user actions (like clicks or typing) instead of following a rigid, top-down sequence. This keeps the interface fully responsive and makes the application feel intuitive and controlled by the user.\n\n" +
                     "2. How does async/await improve the performance of database operations?\n" +
                     "Answer: It prevents the main application window from freezing while waiting for a slow database query to finish. By running the task in the background, it frees up the main thread so the user can continue interacting with the app, improving overall responsiveness and scalability.";

            MessageBox.Show(answers, "Follow-Up Questions Answers");
        
    }
    }
}