namespace Exam1
{
    public partial class LibraryView : Form
    {

        private ReadFromCloud synchronize;
        private OpenBook openBook;

        public LibraryView(Model m, ReadFromCloud synchronize, OpenBook open)
        {
            this.synchronize = synchronize;
            this.openBook = open;


            InitializeComponent();

        }

        public void SynchronizeLibrary()
        {
            synchronize();
        }

        private void SelectedIndexChanges(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openBook();
        }
    }
}
