
using KOIPLANNER_V._0.Resources.Pages;
using System.Threading.Tasks;

namespace KOIPLANNER_V._0
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }


        private async void  agregarClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPages());
        }

        private async void buscadorCompleted(object sender, EventArgs e) {


            await Navigation.PushAsync(new ShowPedidoPage());
            //await DisplayAlert("Se busco su pedido", "no existe su pedido", "ok");
        }


        private async void  pedidosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowListPedidoPage());
            
        }
    }
}
