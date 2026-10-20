using BusinessCard.ViewModels;

namespace BusinessCard.Views;

public partial class MainPageMobile : ContentPage
{
    private readonly CardViewModel _viewModel;
    public MainPageMobile(CardViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = _viewModel = viewModel;
    }
}