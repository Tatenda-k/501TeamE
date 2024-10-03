namespace Exam1
{
    public partial class LibraryView : Form
    {

        private ReadFromCloud synchronize;
        private OpenBook openBook;

        private string bookName;

        public LibraryView(Model m, ReadFromCloud synchronize, OpenBook open)
        {
            this.synchronize = synchronize;
            this.openBook = open;


            InitializeComponent();
            synchronize();
        }

        public void SynchronizeLibrary(List<string> list)
        {
            listBox1.Items.Clear();
            foreach (string item in list)
            {
                listBox1.Items.Add(item);
            }
        }

        private void SelectedIndexChanges(object sender, EventArgs e)
        {
            button1.Enabled = true;
            bookName = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openBook(bookName);
        }
    }
}
