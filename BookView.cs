using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class BookView
    {


        private MovePage movePage;
        private AddBookMark addBm;
        private Book book;

        public  BookView(Book book, MovePage move,AddBookMark addbm)
        {
            this.book = book;
            this.movePage = move;
            this.addBm = addbm;


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
        public void UpdateBookMark(int x,bool add )
        {

        }

       
    }
}
