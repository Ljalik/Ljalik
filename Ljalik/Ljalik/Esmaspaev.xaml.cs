using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ljalik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Esmaspaev : ContentPage
    {
        public Esmaspaev()
        {
            //InitializeComponent();
            string[] tasks = new string[] { "Проснулся (из-за выстрелов артелерии по нашим окопам)", "Кушаю завтрак (после отбитие атаки, на наш окоп)", "Иду в атаку", "Отдыхаю в бараке", "Чищу свое оружие", "Ужинаю", "Ложусь спать" };

            ListView list = new ListView { BackgroundColor = Color.WhiteSmoke, SeparatorColor = Color.Gray, RowHeight = 50, };
            // определяем источник данных
            list.ItemsSource = tasks;

            Button bb = new Button { Text = "Назад" };
            bb.Clicked += Bb_Clicked;

            Button bbk = new Button { Text = "Вперед" };
            bbk.Clicked += Bbk_Clicked;


            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list, bb, bbk } };


        }

        string time;
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string text = e.SelectedItem.ToString();
            if (e.SelectedItemIndex == 0)
            {
                time = "9:24"; //Проснулся
            }

            if (e.SelectedItemIndex == 1)
            {
                time = "10:00";//завтрак
            }

            if (e.SelectedItemIndex == 2)
            {
                time = "12:00";//атака
            }

            if (e.SelectedItemIndex == 3)
            {
                time = "14:00";//отдых
            }

            if (e.SelectedItemIndex == 4)
            {
                time = "18:00";//чистка
            }

            if (e.SelectedItemIndex == 5)
            {
                time = "19:00";//ужин
            }

            if (e.SelectedItemIndex == 6)
            {
                time = "22:00";//ложусь спать
            }

            await DisplayAlert(text, time, "Продолжить");

            StackLayout bubi = new StackLayout();


            Button bb = new Button { Text = "Назад" };
            bb.Clicked += Bb_Clicked;
            bubi.Children.Add(bb);

            Button bbk = new Button { Text = "Вперед" };
            bbk.Clicked += Bbk_Clicked;
            bubi.Children.Add(bbk);
        }

        private async void Bbk_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipaev());
        }

        private async void Bb_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}