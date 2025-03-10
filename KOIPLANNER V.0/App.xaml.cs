namespace KOIPLANNER_V._0
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new MainPage());
            //NO HACE FALTA ESTA LINEA DE CODIGO ESTA OBSOLETA
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}