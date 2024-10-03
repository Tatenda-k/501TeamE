namespace Exam1
{
    partial class BookViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            Page = new Label();
            Author = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(499, 56);
            Title.Margin = new Padding(5, 0, 5, 0);
            Title.Name = "Title";
            Title.Size = new Size(121, 32);
            Title.TabIndex = 0;
            Title.Text = "Book Title";
            Title.Click += label1_Click;
            // 
            // Page
            // 
            Page.AutoSize = true;
            Page.Location = new Point(301, 286);
            Page.Margin = new Padding(5, 0, 5, 0);
            Page.Name = "Page";
            Page.Size = new Size(65, 32);
            Page.TabIndex = 1;
            Page.Text = "Page";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(499, 136);
            Author.Margin = new Padding(5, 0, 5, 0);
            Author.Name = "Author";
            Author.Size = new Size(87, 32);
            Author.TabIndex = 2;
            Author.Text = "Author";
            Author.Click += Author_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(499, 286);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 39);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(499, 419);
            checkBox1.Margin = new Padding(5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(211, 36);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Bookmark Page";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(146, 534);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 5;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1001, 534);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(153, 46);
            button2.TabIndex = 6;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(804, 286);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(153, 46);
            button3.TabIndex = 7;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BookViewForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(Author);
            Controls.Add(Page);
            Controls.Add(Title);
            Margin = new Padding(5);
            Name = "BookViewForm";
            Text = "BookViewForm";
            Load += BookViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Page;
        private Label Author;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}