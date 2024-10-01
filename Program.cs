namespace Exam1
{
    //implemented in controller
    public delegate void MovePage(int x);
    //implemented in bookview
    public delegate void UpdatePage(int x);
    //implemented in bookview
    public delegate void UpdateBookMark(int x, bool add);
    //implemented in controller
    public delegate void ReadFromCloud();
    //called in the lirary view
    public delegate void OpenBook();
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



            Application.Run(new LibraryView(m, c.ReadFromCloud,c.OpenBook));
        }
    }
}