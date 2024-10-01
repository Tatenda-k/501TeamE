using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Book
    {
        private int totalPages;
        private string title;
        private string author;
        private HashSet<int> bookmarks;
        public int curPage { get; set; }

        public Book(int totalPages, string title, string author,int curPage)
        {
            this.totalPages = totalPages;
            this.title = title;
            this.author = author;
            this.curPage = curPage;
            

        }
        
        public void ChangeBookMark(int x, bool add)
        {
            if(add == true)
            {
                bookmarks.Add(x);
            }
            else
            {
                bookmarks.Remove(x);
            }
            
        }
        public void FlipPage(int x)
        {
            if(x < 0)
            {
                curPage -= 1;
            }
            else
            {
                curPage += 1;
            }

        }
        public void GoToPage(int x)
        {
            curPage = x;

        }
    }
}
