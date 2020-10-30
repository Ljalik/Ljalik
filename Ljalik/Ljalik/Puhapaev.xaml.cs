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
    public partial class Puhapaev : ContentPage
    {
        public Puhapaev()
        {
            InitializeComponent();
            string[] tasks = new string[] { "Пробудился", "Позавтракал", "Стоял на посту", "Пошел обедать", "Отдыхаю", "Играю в карты", "Ужинаю", "Ложусь спать" };
            ListView list = new ListView { BackgroundColor = Color.WhiteSmoke, SeparatorColor = Color.Gray, RowHeight = 50, };
            list.ItemsSource = tasks;
            Button bb = new Button { Text = "Назад" };
            bb.Clicked += Bb_Clicked;
            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list, bb,  } };
        }

        private async void Bb_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string text = e.SelectedItem.ToString();
            if (e.SelectedItemIndex == 0)
            {
                Time = "9:24"; //Проснулся
            }
            if (e.SelectedItemIndex == 1)
            {
                Time = "10:00";//завтрак
            }

            if (e.SelectedItemIndex == 2)
            {
                Time = "12:00";//атака
            }

            if (e.SelectedItemIndex == 3)
            {
                Time = "14:00";//отдых
            }

            if (e.SelectedItemIndex == 4)
            {
                Time = "18:00";//чистка
            }

            if (e.SelectedItemIndex == 5)
            {
                Time = "19:00";//ужин
            }

            if (e.SelectedItemIndex == 6)
            {
                Time = "22:00";//ложусь спать
            }
            await DisplayAlert(text, Time, "Продолжить");
        }

        string Time;

    }

}