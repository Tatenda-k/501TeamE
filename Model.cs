using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Model
    {

        public List<Book> CloudLibrary;

        public Model()
        {

        }

        public void LoadInBooksFromTxt()
        {
            CloudLibrary.Add(new Book(100, "Amala's Book", "Amala John", 1));
            CloudLibrary.Add(new Book(250, "Tatenda's Book", "Tatenda Sebekanja", 1));
            CloudLibrary.Add(new Book(200, "Kylie's Book", "Kylie Phommasack", 1));
            CloudLibrary.Add(new Book(300, "Kaitlyn's Book", "Kaitlyn Pritchard", 1));
        }


        //OpenBook
        //CloseBook
    }
}
