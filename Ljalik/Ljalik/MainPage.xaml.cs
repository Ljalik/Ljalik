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
            Button tsp_btn = new Button { Text = "Teisipäev" };
            st.Children.Add(tsp_btn);
            tsp_btn.Clicked += new EventHandler(Btns_Click);
            Button kol_btn = new Button { Text = "Kolmapäev" };
            st.Children.Add(kol_btn);
            kol_btn.Clicked += new EventHandler(Btns_Click);
            Button nel_btn = new Button { Text = "Neljapäev" };
            st.Children.Add(nel_btn);
            nel_btn.Clicked += new EventHandler(Btns_Click);
            Button red_btn = new Button { Text = "Reede" };
            st.Children.Add(red_btn);
            red_btn.Clicked += new EventHandler(Btns_Click);
            Button lul_btn = new Button { Text = "Laupäev" };
            st.Children.Add(lul_btn);
            lul_btn.Clicked += new EventHandler(Btns_Click);
            Button puh_btn = new Button { Text = "Pühapäev" };
            st.Children.Add(puh_btn);
            puh_btn.Clicked += new EventHandler(Btns_Click);
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
                    await Navigation.PushAsync(new Teisipaev());//открывается Teisipaev
                    break;
                case "Kolmapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Kolmapaev());//открывается Kolmapaev
                    break;
                case "Neljapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Neljapaev());//открывается Neljapäev
                    break;
                case "Reede":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Reede());//открывается Reede
                    break;
                case "Laupäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Teisipaev());//открывается Laupaev
                    break;
                case "Pühapäev":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Teisipaev());//открывается Puhapaev
                    break;
                    throw new NotImplementedException();
            }
        }
    }
}
