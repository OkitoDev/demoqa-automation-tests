namespace Tests.PageObjects
{
    public class Forms
    {
        public AlertsPage AlertsPage { get; }
        public BrowserWindowsPage BrowserWindowsPage { get; }
        public FramesPage FramesPage { get; }
        public LinksPage LinksPage { get; }
        public MainPage MainPage { get; }
        public NestedFramesPage NestedFramesPage { get; }
        public RegistrationForm RegistrationForm { get; }
        public SamplePage SamplePage { get; }
        public SelectMenuForm SelectMenuForm { get; }
        public WebTablesPage WebTablesPage { get; }

        public Forms()
        {
            AlertsPage = new AlertsPage();
            BrowserWindowsPage = new BrowserWindowsPage();
            FramesPage = new FramesPage();
            LinksPage = new LinksPage();
            MainPage = new MainPage();
            NestedFramesPage = new NestedFramesPage();
            RegistrationForm = new RegistrationForm();
            SamplePage = new SamplePage();
            SelectMenuForm = new SelectMenuForm();
            WebTablesPage = new WebTablesPage();
        }
    }
}