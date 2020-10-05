namespace DevReach2020.Forms.Portable
{
    public partial class App
    {
        public static AppShell AppShell { get; set; }

        public App()
        {
            AppShell = new AppShell();
            MainPage = AppShell;
        }
    }
}
