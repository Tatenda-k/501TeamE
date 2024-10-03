using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class BookViewForm : Form
    {
        private MovePage movePage;
        private ChangeBookMark addBm;
        private Book book;

        public BookViewForm(Book book, MovePage move, ChangeBookMark addbm)
        {
            this.book = book;
            this.movePage = move;
            this.addBm = addbm;
            InitializeComponent();
            Title.Text = book.title;
            Author.Text = book.author;
            textBox1.Text = book.curPage.ToString();
            UpdatePage(book.curPage);
        }

        /// <summary>
        /// change the display to page x 
        /// </summary>
        /// <param name="x">the page to go to</param>
        public void UpdatePage(int x)
        {
            textBox1.Text = x.ToString();
            checkBox1.Checked = false;
            if (book.bookmarks.Count > 0)
            {
                foreach (int p in book.bookmarks)
                {
                    if (p == x)
                    {
                        checkBox1.Checked = true;
                    }
                }
            }           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int p;
            bool x = int.TryParse(textBox1.Text.ToString(), out p);
            addBm(p, checkBox1.Checked);
        }

        //turn left
        private void button1_Click(object sender, EventArgs e)
        {
            int p;
            bool x = int.TryParse(textBox1.Text.ToString(), out p);
            movePage(p - 1);

        }

        //turn right
        private void button2_Click(object sender, EventArgs e)
        {
            int p;
            bool x = int.TryParse(textBox1.Text.ToString(), out p);
            movePage(p + 1);

        }

        //go to page
        private void button3_Click(object sender, EventArgs e)
        {
            int p;
            bool x = int.TryParse(textBox1.Text.ToString(), out p);
            movePage(p);
        }
    }
}
