namespace Exam1
{

    //implemented in controller
    public delegate void AddBookMark(int x, bool add);
    //implemented in controller
    public delegate void MovePage(int x);
    //implemented in bookview
    public delegate void UpdatePage(int x);
    //implemented in bookview
    public delegate void UpdateBookMark(int x, bool add);
    //implemented in controller
    public delegate void ReadFromCloud();
    //called in the lirary view
    public delegate void OpenBook(string s);
    //called in the bookview
    public delegate void CloseBook();
    //called in the controller
    public delegate void UpdateLibrary(List<string> list);

    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Model m = new Model();
            //BookView bv = new BookView();
            Controller c = new Controller(m);
            LibraryView l = new LibraryView(m, c.ReadFromCloud, c.OpenBook);
            c.SetDelegates(l.SynchronizeLibrary);
            Application.Run(l);
        }
    }
}