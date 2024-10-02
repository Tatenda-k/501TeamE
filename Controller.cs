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
        private Model m;

        private Book? curBook;

        public Controller(Model m )
        {
            this.m = m;
            
          

        }
        public void SetDelegates(UpdatePage updatep, UpdateBookMark updatebm)
        {
            this.updatePage = updatep;
            this.updateBookMark = updatebm;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"> the page to move to</param>
        public void MoveToPage(int x)
        {
            curBook.GoToPage(x);

        }
        public  void ReadFromCloud()
        {

        }
        public void AddBookMark(int x, bool add)
        {
            curBook.ChangeBookMark(x, add);
        }

        /// <summary>
        /// sets the current book
        /// </summary>
        public void OpenBook(Book book)
        {
            curBook = book;
            

        }

       






    }

    
}
