using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Controller
    {
        private UpdatePage? updatePage;
        private UpdateBookMark? updateBookMark;
        private UpdateLibrary? UpdateLibrary;
        private Model m;
        private Book? curBook;
        private int curPage;

        public Controller(Model m)
        {
            this.m = m;                    
        }

        public void SetDelegates(UpdateLibrary updateLibrary)
        {
            this.UpdateLibrary = updateLibrary; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"> the page to move to</param>
        public void MoveToPage(int x)
        {
            if(x > curBook.totalPages || x < 1)
            {
                MessageBox.Show("Out of bounds");
                return;
            }
            curBook.GoToPage(x);
            updatePage(x);
        }

        public  void ReadFromCloud()
        {
            m.LoadInBooksFromTxt();
            List<string> list = new List<string>();
            foreach (Book b in m.CloudLibrary)
            {
                list.Add(b.title);
            }    
            UpdateLibrary(list);
        }

        public void ChangeBookMark(int x, bool add)
        {
            curBook.ChangeBookMark(x, add);
        }

        /// <summary>
        /// sets the current book
        /// </summary>
        public void OpenBook(string book)
        {
            foreach (Book b in m.CloudLibrary)
            {
                if (b.title == book)
                {
                    curBook = b;
                }
            }
            BookViewForm bv = new BookViewForm(curBook, MoveToPage, ChangeBookMark, CloseBook);
            this.updatePage = bv.UpdatePage;
            bv.Show();
        }

        public void CloseBook()
        {

        }
    }    
}
