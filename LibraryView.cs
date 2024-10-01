namespace Exam1
{
    public partial class LibraryView : Form
    {

        private ReadFromCloud synchronize;
        public LibraryView(Model m, ReadFromCloud synchronize)
        {
            this.synchronize = synchronize;


            InitializeComponent();
        }
    }
}
