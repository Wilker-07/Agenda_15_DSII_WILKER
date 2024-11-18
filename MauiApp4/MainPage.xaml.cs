using MauiApp4.Models;
using MauiApp4.Views;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            Evento ev = new Evento();
            ev.Nome = NomeEv.Text;
            ev.Inicio = comeco.Date;
            ev.Fim = dtpck_fm.Date;
            ev.NumP =int.Parse(Part.Text);
            ev.Custa = int.Parse(Custo.Text);
            ev.Local = Local.Text;

            await Navigation.PushAsync(new NewPage1()
            {
                BindingContext = ev
            });
           
        }
    }

}
