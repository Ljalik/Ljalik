using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ljalik
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            StackLayout st = new StackLayout();
            Button esm_btn = new Button { Text = "Esmaspäev" };

            st.Children.Add(esm_btn);
            esm_btn.Clicked += new EventHandler(Btns_Click);
            Content = st;
        }

        private async void Btns_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)//проверяем текст на кнопке
            {
                case "Esmaspäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Esmaspaev());//открывается esmaspaev
                    break;
                case "Teisipäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Teisipaev());//открывается Esmaspaev
                    break;


                    throw new NotImplementedException();
            }
        }
    }
}
