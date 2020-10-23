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
            //массив план на день
            string[] tasks = new string[] { "Подъем", "Умывание", "Прогулка", "Прием пищи", "Поиграть в комп", "Спать" };
            ListView List = new ListView();//список для отражения значений массива
            List.ItemsSource = tasks;//данные из массива отображаем в списке
            List.ItemSelected += List_ItemSelected;//инициализирукем функцию при клике на пункты списка
            Content = new StackLayout { Children = { List } };//отображем список га экране
        }

        private void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           if (e.SelectedItem !=null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItem==0)//если выбран
            }
        }
    }
}