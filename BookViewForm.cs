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
        private AddBookMark addBm;
        private Book book;
        private CloseBook close;

        public BookViewForm(Book book, MovePage move, AddBookMark addbm, CloseBook close)
        {
            this.book = book;
            this.movePage = move;
            this.addBm = addbm;
            this.close = close;
            InitializeComponent();
        }

        /// <summary>
        /// change the display to page x 
        /// </summary>
        /// <param name="x">the page to go to</param>
        public void UpdatePage(int x)
        {

        }

        /// <summary>
        /// toggle the checkmark for bookmartk
        /// </summary>
        /// <param name="x"></param>
        /// <param name="add">whether book mark should be added</param>
        public void UpdateBookMark(int x, bool add)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Author_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void BookViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
