namespace Exam1
{
    public partial class LibraryView : Form
    {

        private ReadFromCloud synchronize;
        private OpenBook openBook;
        
        public LibraryView(Model m, ReadFromCloud synchronize,OpenBook open)
        {
            this.synchronize = synchronize;
            this.openBook = open;


            InitializeComponent();
        }




    }
}
