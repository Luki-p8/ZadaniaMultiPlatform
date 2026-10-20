using BusinessCard.ViewModels;

namespace BusinessCard.Views;

public partial class MainPageDesktop : ContentPage
{
    private readonly CardViewModel _viewModel;
    public MainPageDesktop(CardViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = _viewModel = viewModel;
    }
}