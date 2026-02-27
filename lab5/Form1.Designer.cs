namespace lab5
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            btnEdit = new Button();
            btnShow = new Button();
            btnDelete = new Button();
            txtBookID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnFollowUpQuestion = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(494, 74);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(275, 27);
            txtAuthorName.TabIndex = 0;
            txtAuthorName.TextChanged += textBox1_TextChanged;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(494, 125);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(275, 27);
            txtBookTitle.TabIndex = 2;
            txtBookTitle.TextChanged += txtBookTitle_TextChanged;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(494, 224);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(69, 30);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "ADD";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(33, 46);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(425, 304);
            listBoxBooks.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(694, 225);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(494, 291);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(275, 29);
            btnShow.TabIndex = 6;
            btnShow.Text = "SHOW";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(597, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DEL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(494, 176);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(275, 27);
            txtBookID.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 51);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 9;
            label1.Text = "Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 102);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 10;
            label2.Text = "Book Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 155);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "Book ID";
            // 
            // btnFollowUpQuestion
            // 
            btnFollowUpQuestion.Location = new Point(33, 377);
            btnFollowUpQuestion.Name = "btnFollowUpQuestion";
            btnFollowUpQuestion.Size = new Size(736, 29);
            btnFollowUpQuestion.TabIndex = 12;
            btnFollowUpQuestion.Text = "See: Follow Up Question";
            btnFollowUpQuestion.UseVisualStyleBackColor = true;
            btnFollowUpQuestion.Click += btnFollowUpQuestion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFollowUpQuestion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBookID);
            Controls.Add(btnDelete);
            Controls.Add(btnShow);
            Controls.Add(btnEdit);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Button btnEdit;
        private Button btnShow;
        private Button btnDelete;
        private TextBox txtBookID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnFollowUpQuestion;
    }
}
