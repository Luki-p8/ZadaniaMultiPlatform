using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BusinessCard.ViewModels
{
    public partial class CardViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _header = "Witaj";
        [ObservableProperty]
        private int _headerId = 0;
        [ObservableProperty]
        private string _descriptionBloat = "";

        private string[] headers = { "Witaj", "Hej", "Siema", "Pozdrawiam", "Serwus", "Elo" };

        Random rand = new Random();

        [RelayCommand]
        private void SwitchHeaders()
        {
            HeaderId = rand.Next(headers.Length);

            DescriptionBloat = rand.GetString("qwertyuiopasdfghjklzxcvbnm ", 256);

            Header = headers[HeaderId];
        }
    }
}
