namespace lab6
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
            txtBookID = new TextBox();
            btnAddBook = new Button();
            btnShow = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            listBoxBooks = new ListBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnFollowUpQ = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(78, 39);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(262, 23);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(78, 83);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(262, 23);
            txtBookTitle.TabIndex = 1;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(78, 127);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(262, 23);
            txtBookID.TabIndex = 2;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(78, 186);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(262, 23);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "ADD";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(78, 235);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(262, 23);
            btnShow.TabIndex = 4;
            btnShow.Text = "SHOW";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(78, 284);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(262, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(78, 333);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(262, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(78, 382);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(262, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(416, 21);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(301, 334);
            listBoxBooks.TabIndex = 8;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(416, 382);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(301, 23);
            progressBar1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 10;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 11;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 12;
            label3.Text = "ID";
            // 
            // btnFollowUpQ
            // 
            btnFollowUpQ.Location = new Point(78, 413);
            btnFollowUpQ.Name = "btnFollowUpQ";
            btnFollowUpQ.Size = new Size(639, 25);
            btnFollowUpQ.TabIndex = 13;
            btnFollowUpQ.Text = "FOLLOW UP QUESTION";
            btnFollowUpQ.UseVisualStyleBackColor = true;
            btnFollowUpQ.Click += btnFollowUpQ_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFollowUpQ);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(listBoxBooks);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnShow);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookID);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private TextBox txtBookID;
        private Button btnAddBook;
        private Button btnShow;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private ListBox listBoxBooks;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnFollowUpQ;
    }
}
