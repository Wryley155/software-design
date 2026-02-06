namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ProcessBook(Book[] books)
        {
            listBox1.Items.Clear();
            foreach (Book b in books)
            {
                listBox1.Items.Add(b.GetDetails());
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Book[] bookstoreInventory = new Book[]
    {
        new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
        new Magazine { Title = "National Geographic", IssueDate = "Feb 2026" },
        new Ebook { Title = "Digital Minimalism", FileSizeMB = 2.4 },
        new Textbook { Title = "University Physics", Subject = "Science" },
        new Audiobook { Title = "The Hobbit", Narrator = "Andy Serkis", Duration = "10h 25m" }
    };
       ProcessBook(bookstoreInventory);
        }
    }
    public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public virtual string GetDetails()
		{ return $"Title: {Title}, Author: {Author}"; }
	}
    public class Magazine : Book
    {
        public string IssueDate { get; set; }
        public override string GetDetails()
        { return $"Title: {Title}, Author: {Author}, Issue Date: {IssueDate}"; }
    }
    public class Ebook : Book
    {
        public double FileSizeMB { get; set; }
        public override string GetDetails()
        { return $"Title: {Title}, Author: {Author}, File Size: {FileSizeMB} MB"; }
    }   
    public class Textbook : Book
	{
		public string Subject { get; set; }
		public override string GetDetails()
		{ return $"Title: {Title}, Author: {Author}, Subject: {Subject}"; }
	}
	public class Audiobook : Book
	{
		public string Duration { get; set; }
		public string Narrator { get; set; }
		public override string GetDetails() {

			return $"Title: {Title}, Author: {Author}, Duration: {Duration}, Narrator: {Narrator}";
		}
    


	}
}
/*
 1.How does polymorphism improve flexibility in object-oriented design?

Polymorphism makes a system flexible because it allows us to write one piece of code that can handle many different types of objects at once. 
Instead of writing separate functions for every single new class we create (like one for Magazines and one for AudioBooks),
we can just write one function that talks to the "Parent" class. The system then automatically figures out which specific behavior to use at runtime. 
This means we can add new features or classes later on without having to rewrite or break the existing logic.

2.What is the advantage of using inheritance to extend functionality?

The biggest advantage of inheritance is that it stops us from repeating ourselves.
We can put all the common stuff—like "Title" and "Author"—in one base class and then just "borrow" it for all the other classes. 
When we need to add something new, like a "Textbook" or an "AudioBook," we don’t have to start from scratch;
we just extend the base class and only add the unique parts (like the Subject or Narrator).
It keeps the code organized, easy to read, and much faster to update.
 */